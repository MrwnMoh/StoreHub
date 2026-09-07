using Shop_Desktop_Business.Cart;
using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Cart;
using StoreHub_Desktop.Forms.Global;
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
        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        public Action<int> OnCartItemChanges;


        public bool _clickOn = true;

        public bool CanClick = true;

        int _productId;
        public uctrlProductSamary()
        {
            InitializeComponent();

            OnClick(this);
        }

        void OnClick(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                OnClick(ctrl);

                if (ctrl != btnAddToCart && ctrl != btnBuyNow)
                    ctrl.Click += async (s, e) => await OpenProductsDetails();

            }
        }

        public async Task SetDataById(int id)
        {
            DTO_ProductsSummary product = await clsProducts.GetProductSummaryById(id);

            SetData(product);

        }

        public void SetData(DTO_ProductsSummary product)
        {
            lblProductName.Text = product.ProductName;
            lblProductCategory.Text = product.CategoryName;
            lblPrice.Text = "$" +product.Price.ToString("N2");

            SetRatingData(product.TotalRating.Value, product.RatingAverage.Value);

            clsUtilty.LoadProductImage(pbProductImage, product.ImagePath);

            _productId = product.ProductID;
        }

        void SetRatingData(int totalRating, decimal ratingAvg)
        {
            lblTotalRating.Text = $"({totalRating})";
            lblRatingAvg.Text = ratingAvg.ToString();

            guna2RatingStar1.Value = (float)ratingAvg;
        }

        async Task<DTO_ProductsDetails> GetDetails()
        {
            try
            {
                DTO_ProductsDetails details = await clsProducts.GetProductsDetailsById(_productId);

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

            if (!CanClick)
                return;

            _clickOn = false;
            DTO_ProductsDetails details = await GetDetails();

            if (details != null)
            {
                frmProductsDetails frm = new frmProductsDetails();

                frm.OnReviewsRefresh += SetRatingData;
                frm.OnBuyNow += () => OnBuyNow?.Invoke();
                frm.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                frm.OnViewCartOpnnedThenItemDeleted += (c) => { OnCartItemChanges?.Invoke(c); };
                await frm.SetData(details);

                frm.ShowDialog();
            }


            _clickOn = true;
        }

        private async void btnAddToCart_Click(object sender, EventArgs e)
        {
            btnAddToCart.Enabled = false;
            await AddItem();
        }

        async Task<bool> AddItem(bool showAdded = true)
        {
            btnAddToCart.Enabled = false;
            try
            {
                bool res = await clsCart.AddItemToCart(_productId);
                if(res)
                { 
                    OnItemAddedToCart?.Invoke();
                    btnAddToCart.Enabled = true;
                }
                else
                {
                    clsUtilty.PrintWarn("No stock avalible");
                    return false;
                }

                if(showAdded)
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
            await frm.SetData(_productId);
            frm.ShowDialog();
        }

        void OpenCart()
        {
            Hide();
            frmCart frm = new frmCart();
            frm.OnCartCountChanges += (c) => { OnCartItemChanges?.Invoke(c); };
            frm.ShowDialog();
        }

        private async void btnBuyNow_Click(object sender, EventArgs e)
        {
            btnBuyNow.Enabled = false;
            bool res = await AddItem(false);
            if (res)
            {
                OnBuyNow?.Invoke();
                btnBuyNow.Enabled = true;
            }

        }
    }
}
