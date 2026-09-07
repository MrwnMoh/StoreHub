using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Products
{
    public partial class HomeProducts : UserControl
    {

        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        public Action OnViewAllProduct;


        public Action<int> OnCartItemChanges;
        public Action<int> OnViewCartOpnnedThenItemDeleted;

        public HomeProducts()
        {
            InitializeComponent();
        }

        public async Task LoadHomeProducts()
        {
            try
            {
                flpContaner.Controls.Clear();

                var products = await clsProducts.LoadHomeProducts();



                if (products != null)
                {
                    await SetShowingInfo(products.Count);

                    foreach (var product in products)
                    {
                        uctrlProductSamary uc = new uctrlProductSamary();

                        uc.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                        uc.OnBuyNow += () => OnBuyNow?.Invoke();
                        uc.OnCartItemChanges += (c) => OnCartItemChanges?.Invoke(c);
                        uc.Margin = new Padding(10, 8, 10, 0);

                        uc.SetData(product);
                        flpContaner.Controls.Add(uc);
                    }
                }

            }
            catch (Exception ex)
            {
                clsUtilty.PrintWarn(ex.Message);
            }
        }


        async Task SetShowingInfo(int numberOfLoadedProductds)
        {

            try
            {
                int Total = await clsProducts.NumberOfTotalProducts();

                lblShowingInfo.Text = $"Showing {numberOfLoadedProductds} of {Total} products";

            }
            catch (Exception ex)
            {
                clsUtilty.PrintWarn(ex.Message);
            }



        }

        private void uctrlProductSamary4_Load(object sender, EventArgs e)
        {
        }

        private void lblViewAllBtn_Click(object sender, EventArgs e)
        {
            OnViewAllProduct?.Invoke();
        }
    }
}
