using Shop_Desktop_Business;
using StoreHub_Desktop.Forms.Prouducts;
using StoreHub_DTOs.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StoreHub_Desktop.User_Controls.Products
{
    public partial class uctrlProductSamary : UserControl
    {

        int id = 0;
        public uctrlProductSamary()
        {
            InitializeComponent();
            OnClick(this);
        }

        void OnClick(Control parent)
        {
            foreach(Control ctrl in parent.Controls)
            {
               
              OnClick(ctrl);

                ctrl.Click += async (s, e) => await OpenProductsDetails();

            }
        }

        public void SetData(DTO_ProductsSamary product)
        {
            lblProductName.Text = product.ProductName;
            lblProductCategory.Text = product.CategoryName;
            lblPrice.Text = product.Price.ToString("N2");

            SetRatingData(product.TotalRating.Value, product.RatingAverage.Value);


            id = product.ProductID;
        }

        void SetRatingData(int totalRating,decimal ratingAvg)
        {
            lblTotalRating.Text = $"({totalRating})";
            lblRatingAvg.Text = ratingAvg.ToString();

            guna2RatingStar1.Value = (float)ratingAvg;
        }

       async Task<DTO_ProductsDetails> GetDetails()
        {
            try
            {
                DTO_ProductsDetails details = await clsProducts.GetProductsDetailsById(id);

                if (details != null)
                {
                    return details;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }


        async Task OpenProductsDetails()
        {
            try
            {
                DTO_ProductsDetails details = await GetDetails();

                if (details != null)
                {
                    frmProductsDetails frm = new frmProductsDetails();

                   frm.OnReviewsRefresh += SetRatingData;

                   await frm.SetData(details);

                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
