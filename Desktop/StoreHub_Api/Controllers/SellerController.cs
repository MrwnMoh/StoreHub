using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using StoreHub_Api.Classes;
using StoreHub_Business.Order;
using StoreHub_Business.Reviews;
using StoreHub_Business.Seller;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.Reviews;
using StoreHub_DTOs.Store;
using System.Security.Claims;

namespace StoreHub_Api.Controllers
{
    [Authorize]
    [EnableRateLimiting("Cart")]

    [Route("api/Seller")]
    [ApiController]
    public class SellerController : ControllerBase
    {



        private readonly IAuthorizationService _authorizationService;
        public SellerController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }



        [HttpPost("CreateStore")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> CreateStore([FromBody] DTO_SellerCreateStoreRequest request)
        {
            if (request.PersonId <= 0 || string.IsNullOrWhiteSpace(request.StoreName))
            {
                return BadRequest("Data not accepted");
            }


            try
            {


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, request.PersonId))
                {
                    return Forbid();
                }

                int storeId = await clsSeller.CreateSotre(request);

                if (storeId != null && storeId > 0)
                    return Ok(storeId);

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpPost("CreateProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> CreateProduct([FromBody] DTO_SellerCreateNewProduct request)
        {
            if (request.CategoryId <= 0 || request.StoreId <= 0 || request.Price <= 0 || request.StockQuantity <= 0 || string.IsNullOrWhiteSpace(request.ProductName) || request.ProductImagePaths.Count > 4)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
                {
                    return Forbid();
                }

                int id = await clsSeller.CreateProduct(request);

                if (id != null && id > 0)
                    return Ok(id);

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpPut("Product")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> EditProduct([FromBody] DTO_SellerEditProduct request)
        {
            if (request.CategoryId <= 0 || request.ProductId <= 0 || request.Price <= 0 || request.StockQuantity <= 0 || string.IsNullOrWhiteSpace(request.ProductName) || request.ProductImagePaths.Count >4)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
                {
                    return Forbid();
                }

                bool res = await clsSeller.EditProduct(request);

                    return Ok(res);


            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpGet("StoreById/{storeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_SellerGetStoreSammary>> StoreByStoreID(int storeId)
        {
            if (storeId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {

               

                var store = await clsSeller.LoadStoreByStoreID(storeId);

                if (store != null)
                   {

                    if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, store.PersonId))
                    {
                        return Forbid();
                    }

                    return Ok(store);
                
                
                
                    }
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpGet("Orders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_MyOrdersResponse>> GetStoreOrders([FromQuery] DTO_SellerStoreOrdersRequest request)
        {
            if (request.PageNumber <= 0 || request.PageSize <= 0 || (request.StoreId.HasValue && request.StoreId.Value <=0 ))
            {
                return BadRequest("Data not accepted");
            }



            try
            {

                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
                {
                    return Forbid();
                }

                var store = await clsSeller.StoreOrders(request);


                if (store != null)
                {
                    return Ok(store);
                }
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }




        [HttpGet("Reviews")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DTO_ReviewViewResponse>> GetReviewForStore([FromQuery] DTO_ReviewViewRequest request)
        {
            if (request.PageNumber > 0 && request.PageSize > 0 && request.PersonId >0 && request.StoreId.Value >0)
            {
                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, request.PersonId))
                {
                    return Forbid();
                }


                var reviews = await clsSeller.GetReviewsByStoreId(request);

                if (reviews == null)
                    return NoContent();

                return Ok(reviews);
            }

            return BadRequest();
        }






        [HttpGet("FirstStore/{personId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_SellerGetStoreSammary>> FirstStore(int personId)
        {
            if (personId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {

                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
                {
                    return Forbid();
                }

                   var store = await clsSeller.FirstStore(personId);


                if (store != null)
                    return Ok(store);
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("Stores/{personId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<DTO_SellerStoreNameAndId>>> LoadStoresNameAndId(int personId)
        {
            if (personId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {

                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
                {
                    return Forbid();
                }

                var stores = await clsSeller.LoadStoresNameAndId(personId);


                if (stores != null)
                    return Ok(stores);
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpGet("OrderDetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_OrderDetails>> GetOrderDetailsForStore([FromQuery]DTO_SellerGetOrderDetailsForStore req)
        {
            if (req.StoreId <= 0 || req.OrderId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
                {
                    return Forbid();
                }

                var order = await clsSeller.GetOrdersDetailsForStore(req);

                if (order == null)
                    NotFound();

                return Ok(order);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }




    }
}
