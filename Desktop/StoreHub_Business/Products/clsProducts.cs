using StoreHub_Data.Classes.Other;
using StoreHub_Data.Classes.Products;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Products
{
    public class clsProducts
    {




        public static async Task<List<DTO_ProductsSamary>> GetHomeProducts()
        {
            try
            {
                var products = await ProductsData.GetHomeProducts();

                return products;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<DTO_ProductsDetails> GetProductsDetailsById(int Id)
        {
            try
            {
                var product = await ProductsData.GetProductDetails(Id);

                return product;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<List<DTO_Reviews>> GetProductsReviewsById(int Id)
        {
            try
            {
                var Reviews = await ProductsData.GetProductReviews(Id);

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
                await ProductsData.PostReview(review);

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
                await ProductsData.DeleteReview(review);

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
                await ProductsData.EditReview(review);

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
                return await ProductsData.NumberOfTotalProducts();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
