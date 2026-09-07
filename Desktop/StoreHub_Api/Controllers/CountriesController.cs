using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using StoreHub_Business.Countries;
using StoreHub_Business.Products;
using StoreHub_DTOs.Products;

namespace StoreHub_Api.Controllers
{



    [Authorize]
    [EnableRateLimiting("Auth")]
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {




        [HttpGet("Countries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<string>>> GetCountries()
        {

            var countries = await clsCountries.LoadCountries();

            if (countries == null)
                return NotFound("No countries were found");

            return Ok(countries);
        }





    }
}
