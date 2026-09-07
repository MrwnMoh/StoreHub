using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using StoreHub_Api.Classes;
using StoreHub_Business.Products;
using StoreHub_Business.Reviews;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;

namespace StoreHub_Api.Controllers
{
    [Authorize]
    [EnableRateLimiting("Cart")]

    [Route("api/Reviews")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        public ReviewsController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }



        [HttpGet("Reviews")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DTO_ReviewViewResponse>> GetReviewsForPerson([FromQuery] DTO_ReviewViewRequest request)
        {
            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, request.PersonId))
                {
                    return Forbid();
                }


                var reviews = await clsReviews.GetReviewsByPersonId(request);

                if (reviews == null)
                    return NoContent();

                return Ok(reviews);
            }

            return BadRequest();
        }










    }
}
