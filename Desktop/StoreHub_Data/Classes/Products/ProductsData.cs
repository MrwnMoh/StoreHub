using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_DTOs.Categories;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static StoreHub_DTOs.Products.DTO_ProductsGetAll;

namespace StoreHub_Data.Classes.Products
{
    public class ProductsData
    {


        public static async Task<List<DTO_ProductsSummary>> GetHomeProducts()
        {

            try
            {
                using var context = Settings.CreateContext();


                var products = await context.Products.AsNoTracking()
                    .Where(p=> p.IsDeleted == false && p.StockQuantity > 0)
            .OrderBy(p => Guid.NewGuid())
            .Take(12)
            .Select(p => new DTO_ProductsSummary
            {
                ProductID = p.ProductId,
                ProductName = p.Name,
                Price = p.Price,

                TotalRating = p.Reviews.Count,

                RatingAverage = p.Reviews.Average(r => (decimal?)r.Rate) ?? 0,

                CategoryName = p.Category.Name,

                ImagePath = p.ProductImages
                    .Select(i => i.ImagePath)
                    .FirstOrDefault()
            })
            .ToListAsync();


                return products;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          

            
        }

        public static async Task<DTO_ProductsGetAllResponse> GetAllProducts(DTO_ProductsGetAll request)
        {

            try
            {
                using var context = Settings.CreateContext();

                 var query = context.Products.Where(p => (string.IsNullOrWhiteSpace(request.SearchFilter) || p.Name.Contains(request.SearchFilter)) && p.IsDeleted == false )
                                                    .AsNoTracking().AsQueryable();

                if (request.StoreId > 0)
                {
                    query = query.Where(p => p.StoreId == request.StoreId);
                }


                if (request.CategoryId > 0)
                {
                    query = query.Where(p => p.CategoryId == request.CategoryId);
                }


                switch (request.SortBy)
                {
                    case EProductSort.PriceLowToHigh:
                        query = query.OrderBy(p => p.Price);
                        break;

                    case EProductSort.PriceHighToLow:
                        query = query.OrderByDescending(p => p.Price);
                        break;

                    case EProductSort.AverageReview:
                        query = query.OrderByDescending(p =>
                            p.Reviews.Average(r => (decimal?)r.Rate) ?? 0);
                        break;

                    case EProductSort.Featured:
                        query = query.OrderBy(p => p.OrderItems.Count);
                        break;
                    case EProductSort.LastProdcuts:
                        query = query.OrderByDescending(p => p.ProductId);
                        break;
                    default:
                        query = query.OrderBy(p => p.OrderItems.Count);
                        break;
                }

                int _productsCount = await query.CountAsync();


                int _LastPage = (int)Math.Ceiling( (double)_productsCount / request.PageSize);

                bool hasNextPage = await query
                .Skip(request.PageNumber * request.PageSize)
                .AnyAsync();


                var products = await query
                    .Skip((request.PageNumber -1) * request.PageSize)
            .Take(request.PageSize)
            .Select(p => new DTO_ProductsSummary
            {
                ProductID = p.ProductId,
                ProductName = p.Name,
                Price = p.Price,

                TotalRating = p.Reviews.Count,

                RatingAverage = p.Reviews.Average(r => (decimal?)r.Rate) ?? 0,

                CategoryName = p.Category.Name,
                Stock = p.StockQuantity,
                ImagePath = p.ProductImages
                    .Select(i => i.ImagePath)
                    .FirstOrDefault(),
                CategoryId = p.CategoryId
            })
            .ToListAsync();

                DTO_ProductsGetAllResponse response = new DTO_ProductsGetAllResponse();
                response.Products = products;
                response.HasNextPage = hasNextPage;
                response.LastPageNumber = _LastPage;
                response.AvalibleProductsCount = _productsCount;

                return response;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public static async Task<List<DTO_Category>> GetProductCategories()
        {

            try
            {
                using var context = Settings.CreateContext();


                var Categories = await context.Categories.AsNoTracking()
            .OrderBy(c =>c.CategoryId)
            .Select(c => new DTO_Category
            {
                ID = c.CategoryId,
                Name = c.Name
            })
            .ToListAsync();


                return Categories;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }


        public static async Task<DTO_ProductsSummary> GetProductSummaryById(int Id)
        {

            try
            {
                using var context = Settings.CreateContext();


                var product = await context.Products.AsNoTracking()
                    .Where(p => p.ProductId == Id)
            .Select(p => new DTO_ProductsSummary
            {
                ProductID = p.ProductId,
                ProductName = p.Name,
                Price = p.Price,

                TotalRating = p.Reviews.Count,

                RatingAverage = p.Reviews.Average(r => (decimal?)r.Rate) ?? 0,

                CategoryName = p.Category.Name,

                ImagePath = p.ProductImages
                    .Select(i => i.ImagePath)
                    .FirstOrDefault()
            })
            .FirstOrDefaultAsync();


                return product;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }


        public static async Task<DTO_ProductsDetails> GetProductDetails(int productsId)
        {

            try
            {
                using var context = Settings.CreateContext();


                var product = await context.Products.AsNoTracking()
                    .Where(p => p.ProductId == productsId)
                    .Select(p => new DTO_ProductsDetails
                    {
                        
                        ProductId = p.ProductId,
                        ProductName = p.Name,
                        SellerName = p.Store.StoreName,
                        Price = p.Price,
                        StockQuantity = p.StockQuantity,
                        StoreId = p.StoreId,
                        Description = p.Description?? "",
                        Reviews = p.Reviews.OrderByDescending(r=>r.ReviewId).Select(r=> new DTO_Reviews
                        {UserFullName = r.Person.FirstName + " " + r.Person.LastName, ReviewText = r.ReviewText, Date = r.Date, Rating =  r.Rate, UserImagePath = r.Person.ImagePath,IsUserMale = r.Person.IsMale,PersonID = r.PersonId, ReviewID = r.ReviewId,Edited = r.Edited }).ToList(),
                        Images = p.ProductImages.Select(i => i.ImagePath).ToList(),

                        CategoryName = p.Category.Name
                        
                    })
                    .FirstOrDefaultAsync();


                return product;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public static async Task<List<DTO_Reviews>> GetProductReviews(int productsId)
        {

            try
            {
                using var context = Settings.CreateContext();


                var Reviews = await context.Reviews.AsNoTracking()
                    .Where(r => r.ProductId == productsId)
                    .OrderByDescending(r => r.ReviewId)
                    .Select(r => new DTO_Reviews
                    {
                        ReviewID = r.ReviewId,
                        PersonID = r.PersonId,
                        UserFullName = r.Person.FirstName + " " + r.Person.LastName,
                        ReviewText = r.ReviewText,
                        Date = r.Date,
                        Rating = r.Rate,
                        UserImagePath = r.Person.ImagePath,
                        IsUserMale = r.Person.IsMale,
                        Edited = r.Edited
                        
                    })
                    .ToListAsync();


                return Reviews;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }


        public static async Task PostReview(DTO_ReviewsPost review)
        {

            try
            {
                using var context = Settings.CreateContext();


                await context.Reviews
                    .AddAsync(new Entities.Review {PersonId = review.PersonID,ProductId = review.ProductID,ReviewText = review.ReviewText,Rate =  review.Rating });

                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static async Task EditReview(DTO_ReviewsEdit review)
        {

            try
            {
                using var context = Settings.CreateContext();


                await context.Reviews.Where(r=> r.ReviewId == review.ReviewID)
                    .ExecuteUpdateAsync(r => r.SetProperty(u => u.ReviewText , review.ReviewText).SetProperty(u => u.Rate , review.Rate).SetProperty(u => u.Edited , true));


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task DeleteReview(DTO_ReviewsDelete review)
        {

            try
            {
                using var context = Settings.CreateContext();


                await context.Reviews.Where(r => r.ReviewId == review.ReviewId)
                    .ExecuteDeleteAsync();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<int> NumberOfTotalProducts()
        {

            try
            {
                using var context = Settings.CreateContext();


                return await context.Products.CountAsync();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public static async Task<bool> DeleteProduct(int productId)
        {
            using var context = Settings.CreateContext();

            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {

                int rows = await context.Products.Where(p => p.ProductId == productId).ExecuteUpdateAsync(p => p.SetProperty(p => p.IsDeleted, true));

                await context.CartItems
                    .Where(c => c.ProductId == productId)
                    .ExecuteDeleteAsync();

                await transaction.CommitAsync();

                return rows > 0;

            }
            catch
            {
                transaction.Rollback();
                return false;
            }
            

        }


    }
}
