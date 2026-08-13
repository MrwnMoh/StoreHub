using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreHub_Api.Classes;
using StoreHub_Business.Cart;
using StoreHub_Business.Products;
using StoreHub_DTOs.Cart;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System.Security.Claims;

namespace StoreHub_Api.Controllers
{
    [Authorize]
    [Route("api/Cart")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly IAuthorizationService _authorizationService;
        public CartController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }



        [HttpGet("{PersonId}", Name = "GetCartByPersonId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_Cart>> GetCartByPersonId(int PersonId)
        {
            if (PersonId <= 0)
            {
                return BadRequest("Data not accepted");
            }

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, PersonId))
            {
                return Forbid();
            }


            try
            {
                var cart = await clsCart.GetCartByPersonID(PersonId);

                return Ok(cart);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpPatch("Items/{itemId}/Increase")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> IncreaseItemQuantity(int itemId)
        {
            if (itemId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                if (!int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier),out int personId))
                {
                    return Unauthorized();
                }


                bool res = await clsCart.IncreaseItemQuantity(itemId, personId);


                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpPatch("Items/{itemId}/Decrease")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DecreaseItemQuantity(int itemId)
        {
            if (itemId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                if (!int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out int personId))
                {
                    return Unauthorized();
                }


                await clsCart.DecreaseItemQuantity(itemId, personId);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpDelete("{itemId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteItem(int itemId)
        {
            if (itemId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
           
                await clsCart.DeleteItem(itemId);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }



        [HttpPost("{productId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> AddItemToCart(int productId)
        {
            if (productId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                if (!int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out int personId))
                {
                    return Unauthorized();
                }


                bool res = await clsCart.AddItemToCart(productId, personId);


                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpGet("Quantity/{ProductId}", Name = "GetItemQuantityByProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> GetItemQuantityByProduct(int ProductId)
        {
            if (ProductId <= 0)
                return BadRequest("data not accepted");


            if (!int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out int personId))
            {
                return Unauthorized();
            }


            var Quantity = await clsCart.GetItemQuantityByProduct(ProductId, personId);

            return Ok(Quantity);
        }


        [HttpGet("CartItemsCount/{PersonId}", Name = "GetCartItemsCount")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> GetCartItemsCount(int PersonId)
        {
            if (PersonId <= 0)
                return BadRequest("data not accepted");


            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, PersonId))
            {
                return Forbid();
            }

            var count = await clsCart.GetCartItemsCount(PersonId);

            return Ok(count);
        }





    }
}
