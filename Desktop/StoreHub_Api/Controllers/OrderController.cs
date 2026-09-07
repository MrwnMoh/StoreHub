using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using StoreHub_Api.Classes;
using StoreHub_Business.Cart;
using StoreHub_Business.Order;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Order;
using System.Security.Claims;

namespace StoreHub_Api.Controllers
{


    [Authorize]

    [EnableRateLimiting("Cart")]

    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IAuthorizationService _authorizationService;
        public OrderController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }



        [HttpPost("PlaceOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> PlaceOrder([FromBody] DTO_OrderPlace order)
        {
            if (order.PersonID <= 0 || order.TotalAmount <= 0 || string.IsNullOrWhiteSpace(order.ShippingAddress))
            {
                return BadRequest("Data not accepted");
            }


            try
            {
              

                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, order.PersonID))
                {
                    return Forbid();
                }

                int orderID = await clsOrder.PlaceOrder(order);

                if(orderID != null && orderID >= 0)
                    return Ok(orderID);

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("MyOrders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_MyOrdersResponse>> ViewMyOrders([FromQuery]DTO_OrderViewMyRequest request)
        {
            if (request.PersonId <= 0 || request.PageNumber <= 0 || request.PageSize <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, request.PersonId))
                {
                    return Forbid();
                }

                var orders = await clsOrder.ViewMyOrders(request);

                if(orders == null)
                    NoContent();

                return Ok(orders);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("OrderDetails/{OrderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_OrderDetails>> GetOrderDetails(int OrderId)
        {
            if (OrderId <= 0)
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

                var order = await clsOrder.GetOrdersDetails(OrderId);

                if (order == null)
                    NotFound();

                return Ok(order);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpPut("Cancel/{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> CancelOrder(int orderId)
        {
            if (orderId <= 0)
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

                bool res = await clsOrder.CancelOrder(orderId);

                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpPut("OrderStatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> ChangeOrderStatus([FromBody] DTO_OrderChangeStatus req)
        {
            if (req.OrderId <= 0 || req.StatusId <= 0 || req.OrderId == 2 || req.StatusId > 6)
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

                bool res = await clsOrder.ChangeOrderStatus(req);

                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }






    }
}
