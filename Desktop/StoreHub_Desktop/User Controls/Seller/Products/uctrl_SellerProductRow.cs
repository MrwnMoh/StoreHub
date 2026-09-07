using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Prouducts;
using StoreHub_Desktop.Forms.Seller;
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

namespace StoreHub_Desktop.User_Controls.Seller.Products
{
    public partial class uctrl_SellerProductRow : UserControl
    {
        public uctrl_SellerProductRow()
        {
            InitializeComponent();
        }

        public Action OnItemAddedToCart;
        public Action OnBuyNow;
        public Action ProductDeleted;

        public Action<int> OnCartItemChanges;

        public Action OnClcikEdit;


        int id;

        DTO_ProductsDetails productsDetails;


        public void SetData(DTO_ProductsSummary product)
        {
            lblPrice.Text = product.Price.ToString("N2");
            lblProductCategory.Text = product.CategoryName;
            lblProductName.Text = product.ProductName;
            lblStock.Text = product.Stock.ToString();
            lblTotalRating.Text = product.TotalRating.ToString();
            guna2RatingStar1.Value = (float)product.RatingAverage;
            id = product.ProductID;
            clsUtilty.LoadProductImage(pbProductImage, product.ImagePath);
        }

        void SetData(DTO_ProductsDetails product)
        {
            lblPrice.Text = product.Price.ToString("N2");
            lblProductCategory.Text = product.CategoryName;
            lblProductName.Text = product.ProductName;
            lblStock.Text = product.StockQuantity.ToString();
            clsUtilty.LoadFirstProductImageFromList(pbProductImage, product.Images);
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            await OpenProductsDetails();
            btnView.Enabled = true;
        }

        async Task OpenProductsDetails()
        {
            try
            {

                if (productsDetails == null)
                {
                    productsDetails = await GetDetails();
                }

                if (productsDetails != null)
                {
                    frmProductsDetails frm = new frmProductsDetails();

                    frm.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                    frm.OnBuyNow += () => OnBuyNow?.Invoke();
                    frm.OnViewCartOpnnedThenItemDeleted += (c) => { OnCartItemChanges?.Invoke(c); };
                    await frm.SetData(productsDetails);

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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            await DeleteProduct();
        }

        async Task DeleteProduct()
        {
            bool res = await clsProducts.DeleteProduct(id);
            if (res)
            {
                ProductDeleted?.Invoke();
            }
            else
            {
                clsUtilty.PrintWarn("Error while deleting the product");
                btnDelete.Enabled = true;
            }
        }

        private  void btnEditProduct_Click(object sender, EventArgs e)
        {
            btnEditProduct.Enabled = false;
            OnClcikEdit?.Invoke();
            btnEditProduct.Enabled = true;
        }

        public async Task OpenEdit(List<string>? cateogriesList)
        {
            if(productsDetails == null)
            {
                productsDetails = await GetDetails();
            }
           
            if(productsDetails != null)
            {
                frmAddEditProduct frm = new frmAddEditProduct(productsDetails, productsDetails.StoreId, cateogriesList);
                frm.OnProductSaved += async (product) => {  SetData(product); };
                frm.ShowDialog();
            }

        }

    }
}
