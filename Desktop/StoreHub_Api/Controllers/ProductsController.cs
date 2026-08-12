using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StoreHub_Api.Classes;
using StoreHub_Business.Products;
using StoreHub_Data.Data;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;

namespace StoreHub_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IAuthorizationService _authorizationService;
        public ProductsController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }




        [HttpGet("GetHomeProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<DTO_ProductsSamary>>> GetHomeProducts()
        {

            var products = await clsProducts.GetHomeProducts();

            if(products == null)
                return NotFound("No products were found");

            return Ok(products);
        }


        [HttpGet("TotalProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> NumberOfTotalProducts()
        {

            var total = await clsProducts.NumberOfTotalProducts();

            return Ok(total);
        }


        [HttpGet("{Id}", Name = "GetProductsDetailsById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DTO_ProductsDetails>> GetProductsDetailsById(int Id)
        {
            if (Id <= 0)
                return BadRequest("Id not accepted");

            var product = await clsProducts.GetProductsDetailsById(Id);

            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        [HttpGet("Reviews{Id}", Name = "GetProductsReviewsById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<List<DTO_Reviews>>> GetProductsReviewsById(int Id)
        {
            if (Id <= 0)
                return BadRequest("Id not accepted");

            var Reviews = await clsProducts.GetProductsReviewsById(Id);

            if (Reviews == null)
                return NotFound("Reviews not found");

            return Ok(Reviews);
        }


        [HttpPost("PostReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> PostReview([FromBody]DTO_ReviewsPost review)
        {
            if(review == null || review.ProductID <=0 || review.PersonID <=0 || string.IsNullOrWhiteSpace(review.ReviewText) || review.Rating > 5 ||review.Rating <0)
            {
                return BadRequest("Data not accepted");
            }

            if(! await clsUtilty.CheckOwnerPolicy(User,_authorizationService,review.PersonID))
            {
                return Forbid();
            }


            try
            {
                await clsProducts.PostReview(review);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }




        [HttpPost("EditReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EditReview([FromBody] DTO_ReviewsEdit review)
        {
            if (review == null || review.ReviewID <= 0 || review.Rate <= 0 || string.IsNullOrWhiteSpace(review.ReviewText))
            {
                return BadRequest("Data not accepted");
            }

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, review.PersonID))
            {
                return Forbid();
            }


            try
            {
                await clsProducts.EditReview(review);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpDelete("Review")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteReview([FromBody] DTO_ReviewsDelete review)
        {
            if (review == null || review.ReviewId<= 0 || review.PersonId <= 0)
            {
                return BadRequest("Data not accepted");
            }

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, review.PersonId))
            {
                return Forbid();
            }


            try
            {
                await clsProducts.DeleteReview(review);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


    }
}
