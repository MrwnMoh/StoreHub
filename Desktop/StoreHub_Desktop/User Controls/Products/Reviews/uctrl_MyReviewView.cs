using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Prouducts;
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

namespace StoreHub_Desktop.User_Controls.Products.Reviews
{
    public partial class uctrl_MyReviewView : UserControl
    {
        public uctrl_MyReviewView()
        {
            InitializeComponent();
        }

        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        public Action<int> OnCartItemChanges;
        int id;

        public void SetData(DTO_ReviewView review)
        {
            lblProductName.Text = review.ProductName;
            lblRatingAvg.Text = review.ReviewRate.ToString();
            guna2RatingStar1.Value = (float)review.ReviewRate;


            lblReviewDate.Text = review.ReviewDate.ToShortDateString();

            lblReviewText.Text = review.ReviewText;

            clsUtilty.LoadProductImage(pbProductImage, review.ProductImagePath);

            id = review.ProductId;
        }

        private async void btnViewProduct_Click(object sender, EventArgs e)
        {
            btnViewProduct.Enabled = false;
            await OpenProductsDetails();
            btnViewProduct.Enabled = true;
        }



        async Task OpenProductsDetails()
        {
            try
            {
                DTO_ProductsDetails details = await GetDetails();

                if (details != null)
                {
                    frmProductsDetails frm = new frmProductsDetails();

                    frm.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                    frm.OnBuyNow += () => OnBuyNow?.Invoke();
                    frm.OnViewCartOpnnedThenItemDeleted += (c) => { OnCartItemChanges?.Invoke(c); };
                    await frm.SetData(details);

                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        async Task<DTO_ProductsDetails> GetDetails()
        {
             DTO_ProductsDetails details = await clsProducts.GetProductsDetailsById(id);

             return details;

        }


    }
}
