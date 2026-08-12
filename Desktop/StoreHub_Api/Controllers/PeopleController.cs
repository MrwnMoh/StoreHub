using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreHub_Data.Data;
using StoreHub_DTOs;
using StoreHub_DTOs.People;

namespace StoreHub_Api.Controllers
{

    
    [Authorize]
    [Route("api/Peaople")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        //[HttpGet("GetPeople")]
        //public ActionResult<IEnumerable< DTO_People>> GetPeople()
        //{

        //    var options = new DbContextOptionsBuilder<AppDbContext>()
        //    .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
        //    .Options;

        //    using var context = new AppDbContext(options);


        //    var peaple = context.People.ToList();

        //    return Ok(peaple);


        //}

        [HttpGet("GetPeople")]
        public IActionResult GetPeople()
        {

            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;


            using var context = new AppDbContext(options);

            var data = context.People.Where(p => p.PersonId == 1).Select(p => new {p.FirstName , p.LastName, p.BirthDate,p.RegisterAt,p.IsMale,p.IsAdmin,p.CountryId }).ToList();

            return Ok(data);
        }

        [HttpGet("GetPersonWithStores")]
        public IActionResult GetPersonWithStores()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using var context = new AppDbContext(options);

            var data = context.People
                .Where(p => p.PersonId == 1)
                .Select(p => new
                {
                    p.PersonId,
                    FullName = p.FirstName + " " + p.LastName,

                    Stores = p.Stores.Select(s => new
                    {
                        s.StoreId,
                        s.StoreName
                    }).ToList()
                })
                .ToList();

            return Ok(data);
        }


        [HttpGet("GetStoreWithPerson")]
        public IActionResult GetStoreWithPerson()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using var context = new AppDbContext(options);

            var data = context.Stores
                .Where(s => s.StoreId == 1)
                .Select(s => new
                {
                    s.StoreId,
                    s.StoreName,

                    Person = new
                    {
                        s.Person.PersonId,
                        FullName = s.Person.FirstName + " " + s.Person.LastName
                    }
                })
                .ToList();

            return Ok(data);
        }


        [HttpGet("GetProductWithStoreAndCategory")]
        public IActionResult GetProductWithStoreAndCategory()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using var context = new AppDbContext(options);

            var data = context.Products
                .Where(p => p.ProductId == 1)
                .Select(p => new
                {
                    p.ProductId,
                    p.Name,
                    p.Price,
                    p.StockQuantity,

                    Store = new
                    {
                        p.Store.StoreId,
                        p.Store.StoreName
                    },

                    Category = new
                    {
                        p.Category.CategoryId,
                        p.Category.Name
                    }
                })
                .ToList();

            return Ok(data);
        }

        [HttpGet("GetProductWithImages")]
        public IActionResult GetProductWithImages()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using var context = new AppDbContext(options);

            var data = context.Products
                .Where(p => p.ProductId == 1)
                .Select(p => new
                {
                    p.ProductId,
                    p.Name,

                    Images = p.ProductImages.Select(i => new
                    {
                        i.ProductImageId,
                        i.ImagePath
                    }).ToList()
                })
                .ToList();

            return Ok(data);
        }

        [HttpGet("GetOrderDetails")]
        public IActionResult GetOrderDetails()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using var context = new AppDbContext(options);

            var data = context.Orders
                .Where(o => o.OrderId == 1)
                .Select(o => new
                {
                    o.OrderId,
                    o.OrderDate,
                    o.TotalAmount,

                    Person = new
                    {
                        o.Person.PersonId,
                        FullName = o.Person.FirstName + " " + o.Person.LastName
                    },

                    OrderStatus = new
                    {
                        o.OrderStatus.OrderStatusId,
                        o.OrderStatus.Name
                    },

                    Items = o.Items.Select(i => new
                    {
                        i.OrderItemId,
                        i.Quantity,
                        i.UnitPrice,

                        Product = new
                        {
                            i.Product.ProductId,
                            i.Product.Name
                        }
                    }).ToList()
                })
                .ToList();

            return Ok(data);
        }


    }
}
