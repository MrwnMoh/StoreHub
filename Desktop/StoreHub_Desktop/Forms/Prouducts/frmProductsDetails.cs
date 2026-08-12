using Shop_Desktop_Business;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Properties;
using StoreHub_Desktop.User_Controls.Products.Reviews;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms.Prouducts
{
    public partial class frmProductsDetails : Form
    {
        int productID;
        public Action OnPostCompleted;

        public Action <int, decimal> OnReviewsRefresh;


        public frmProductsDetails()
        {
            InitializeComponent();
        }


        public async Task SetData(DTO_ProductsDetails product)
        {

            productID = product.ProductId;
            lblProductName.Text = product.ProductName;
            lblProductCategory.Text = product.CategoryName;
            lblPrice.Text = product.Price.ToString("N2");
            lblTotalRating.Text = $"({product.Reviews.Count})" ?? "0";
            lblDescription.Text = product.Description;
            lblSeller.Text = product.SellerName;

            decimal ratingAvg = product.Reviews.Any() ? product.Reviews.Average(r => r.Rating) : 0;


            guna2RatingStar1.Value = (float)ratingAvg;

            lblRatingAvg.Text = ratingAvg.ToString("0.0");

            if(product.Images!= null)
            {
                foreach(var img in product.Images)
                {
                    if(File.Exists(img))
                    {
                        pbProductImage.ImageLocation = img;
                        return;
                    }
                }
            }

            await SetReviews(product.Reviews);

            uctrlWriteaReview1.SetUserData();
            uctrlWriteaReview1.OnClickPost += OnClickPostEvnet;
            uctrlWriteaReview1.OnClickEdit += OnClickEditEvnet;
        }

        async void OnClickPostEvnet(string reviewText, decimal rating)
        {
            try
            {

                DTO_ReviewsPost review = new DTO_ReviewsPost();

                review.ReviewText = reviewText;
                review.ProductID = productID;
                review.PersonID = clsDefultes.LogendUser.person.PersonId;
                review.Rating = rating;
                await clsProducts.PostAReview(review);

                await RefreshReviews();

            }
            catch (Exception ex)
            {
                clsUtilty.PrintWarn(ex.Message);
            }

        }

        async void OnClickEditEvnet(DTO_ReviewsEdit edit)
        {
            try
            {

                await clsProducts.EditReview(edit);

                await RefreshReviews();

            }
            catch (Exception ex)
            {
                clsUtilty.PrintWarn(ex.Message);
            }

        }

        async Task RefreshReviews()
        {
            uctrlWriteaReview1.Clear();
            var reviews = await LoadReviews();
            await SetReviews(reviews);
            OnReviewsRefresh?.Invoke(reviews.Count,reviews.Average(r => r.Rating));
        }

        async Task<List<DTO_Reviews>> LoadReviews()
        {
            try
            {

                return await clsProducts.GetProductsReviewsById(productID);
            }
            catch(Exception ex) 
            {
                clsUtilty.PrintWarn(ex.Message);
            }

            return null;
        }

        async Task SetReviews(List<DTO_Reviews> reviews)
        {
            lblReviews.Text = $"Reviews ({reviews.Count})";
            flpReviews.Controls.Clear();
            foreach (var review in reviews)
            {

                uctrlUserReview uc = new uctrlUserReview();
                uc.OnEditReview += uctrlWriteaReview1.SetEditReviewData;
                uc.OnDeleteReview += async () => {await RefreshReviews(); };
                ;
                uc.SetData(review);
                flpReviews.Controls.Add(uc);
            }


        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
