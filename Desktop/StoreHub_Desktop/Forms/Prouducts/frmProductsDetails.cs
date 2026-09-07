using Guna.UI2.WinForms;
using Shop_Desktop_Business.Cart;
using Shop_Desktop_Business.Other;
using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Cart;
using StoreHub_Desktop.Forms.Global;
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

        public Action OnItemAddedToCart;

        public Action OnBuyNow;


        public Action<int> OnViewCartOpnnedThenItemDeleted;


        public Action<int, decimal> OnReviewsRefresh;

        List<Guna2PictureBox> pictureBoxList = new List<Guna2PictureBox>();

        public frmProductsDetails()
        {
            InitializeComponent();


            pictureBoxList.Add(pbImage1);
            pictureBoxList.Add(pbImage2);
            pictureBoxList.Add(pbImage3);
            pictureBoxList.Add(pbImage4);
        }


        public async Task SetData(DTO_ProductsDetails product)
        {

            productID = product.ProductId;
            lblProductName.Text = product.ProductName;
            lblProductCategory.Text = product.CategoryName;
            lblPrice.Text = "$" + product.Price.ToString("N2");
            lblTotalRating.Text = $"({product.Reviews.Count})" ?? "0";
            lblDescription.Text = product.Description;
            lblSeller.Text = product.SellerName;

            decimal ratingAvg = product.Reviews.Any() ? product.Reviews.Average(r => r.Rating) : 0;


            guna2RatingStar1.Value = (float)ratingAvg;

            lblRatingAvg.Text = ratingAvg.ToString("0.0");



            clsUtilty.LoadProductImageFromList(pictureBoxList, product.Images);
            clsUtilty.LoadFirstProductImageFromList(pbProductImage, product.Images);

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
            OnReviewsRefresh?.Invoke(reviews.Count, reviews.Count == 0 ? 0 : reviews.Average(r => r.Rating));
        }

        async Task<List<DTO_Reviews>> LoadReviews()
        {
            try
            {

                return await clsProducts.GetProductsReviewsById(productID);
            }
            catch (Exception ex)
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
                uc.OnDeleteReview += async () => { await RefreshReviews(); };
                ;
                uc.SetData(review);
                flpReviews.Controls.Add(uc);
            }


        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAddToCart_Click(object sender, EventArgs e)
        {
            btnAddToCart.Enabled = false;
            await AddItem();
        }


        async Task<bool> AddItem(bool showAdded = true)
        {
            try
            {
                bool res = await clsCart.AddItemToCart(productID);
                if (res)
                {
                    OnItemAddedToCart?.Invoke();
                    btnAddToCart.Enabled = true;
                }
                else
                {
                    clsUtilty.PrintWarn("No stock avalible");
                    return false;
                }
                OnItemAddedToCart?.Invoke();

                if (showAdded)
                    await OpenProdectAddedForm();

            }
            catch
            {
                clsUtilty.PrintWarn("Error while adding the product");
            }
            return true;
        }

        async Task OpenProdectAddedForm()
        {

            frmProductAddedToCart frm = new frmProductAddedToCart();
            frm.OnClickViewCart += () => { OpenCart(); };
            await frm.SetData(productID);
            frm.ShowDialog();
        }

        void OpenCart()
        {
            Hide();
            frmCart frm = new frmCart();
            frm.OnCartCountChanges += (c) => { OnViewCartOpnnedThenItemDeleted?.Invoke(c); };
            frm.ShowDialog();
            Close();
        }

        private async void btnButNow_Click(object sender, EventArgs e)
        {
            btnButNow.Enabled = false;
            bool res = await AddItem(false);
            if(res)
            {
                OnBuyNow?.Invoke();
                Close();
                btnButNow.Enabled = true;
            }
           
           
        }

        private void pbImage3_Click_1(object sender, EventArgs e)
        {
            pbProductImage.ImageLocation = ((Guna2PictureBox)sender).ImageLocation;
        }
    }
}
