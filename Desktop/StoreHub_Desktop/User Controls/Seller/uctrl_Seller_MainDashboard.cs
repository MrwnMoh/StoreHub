using Shop_Desktop_Business.Other;
using StoreHub_Desktop.User_Controls.Seller.Orders;
using StoreHub_Desktop.User_Controls.Seller.Products;
using StoreHub_Desktop.User_Controls.Seller.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Seller
{
    public partial class uctrl_Seller_MainDashboard : UserControl
    {

        uctrlStoreSammaryDashboard uc = new uctrlStoreSammaryDashboard();

        bool BackToDashboard = false;

        public Action OnPressBack;

        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        public Action<int> OnCartItemChanges;

        public uctrl_Seller_MainDashboard()
        {
            InitializeComponent();
        }
      

        public async void SetData()
        {
            if (!clsDefultes.LogendUser.person.IsSeller)
            {
                SetForNoStore();
                return;
            }

            uc.OnClickProducts += async (c,t) => await OpenProducts(c, t);
            uc.OnClickOrders += async (c) => await OpenOrders(c);
            uc.OnClickReviews += async (c) => await OpenReviews(c);
            await SetStore();
            
        }

        async Task SetStore()
        {
            await uc.SetData(null);
            uc.BackToShopping += async () => await Back();
            pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(uc);
        }

        async Task OpenProducts(int storeId,bool AddProduct)
        {
            uctrlSellerProducts ucProducts = new uctrlSellerProducts();
            ucProducts.OnBuyNow += () => OnBuyNow?.Invoke();
            ucProducts.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
            ucProducts.OnCartItemChanges += (c) => { OnCartItemChanges?.Invoke(c); };
            await ucProducts.SetData(storeId, AddProduct);
            if(!AddProduct)
           {
                pnlContaner.Controls.Clear();
                pnlContaner.Controls.Add(ucProducts);
                BackToDashboard = true;
            }
        }


        async Task OpenOrders(int storeId)
        {
            uctrlStoreOrders ucProducts = new uctrlStoreOrders();
            await ucProducts.LoadData(storeId);
            pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(ucProducts);
            BackToDashboard = true;
        }

        async Task OpenReviews(int storeId)
        {
            uctrl_StoreReviews ucProducts = new uctrl_StoreReviews();
            await ucProducts.LoadData(storeId);
            pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(ucProducts);
            BackToDashboard = true;
        }



        private async void OnCLickBack(object sender, EventArgs e)
        {
            await Back();
        }


        async Task Back()
        {
            if (BackToDashboard)
            {
                pnlContaner.Controls.Clear();
                await SetStore();
                BackToDashboard = false;
            }
            else
                OnPressBack?.Invoke();
        }

        void SetForNoStore()
        {
            pnlContaner.Controls.Clear();
            uctrl_NoStore uc = new uctrl_NoStore();
            uc.OnStoreCreated += async (id) =>
            {
                pnlContaner.Controls.Clear();
                await SetStore();
            };
            uc.Location = new Point(326, 120);
            pnlContaner.Controls.Add(uc);
        }


    }
}
