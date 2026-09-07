using Shop_Desktop_Business.Other;
using StoreHub_Desktop.User_Controls.Admin.Stores;
using StoreHub_Desktop.User_Controls.Admin.Users;
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

namespace StoreHub_Desktop.User_Controls.Admin
{
    public partial class uctrl_AdminMainDashboard : UserControl
    {
        public uctrl_AdminMainDashboard()
        {
            InitializeComponent();
        }

        public Action OnPressBack;

        public Action<int> OnCartItemChanges;


        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        bool BackToDashboard = false;

        public async Task LoadData()
        {
            if (!clsDefultes.LogendUser.person.IsAdmin)
                return;

            await LoadSummary();
        }

        async Task LoadSummary()
        {
            uctrl_AdminDashboardSummary uc = new uctrl_AdminDashboardSummary();


            uc.OnClickUsers += async () => await User();
            uc.OnClickAddUsers += async () => await User(true);
            uc.OnClickProducts += async () => await OpenProducts();
            uc.OnClickOrders += async () => await OpenOrders();
            uc.OnClickStores += async () => await OpenStores();
            uc.BackToShopping += () => OnPressBack?.Invoke();

            await uc.SetData();
            pnlContaner.Controls.Add(uc);
        }

        async Task User(bool addUser = false)
        {
            uctrUsers ucProducts = new uctrUsers();
            await ucProducts.SetData(addUser);
           
            BackToDashboard = true;

            if(!addUser)
                pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(ucProducts);


        }


        async Task OpenProducts()
        {
            uctrlSellerProducts ucProducts = new uctrlSellerProducts();
            ucProducts.OnBuyNow += () => OnBuyNow?.Invoke();
            ucProducts.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
            ucProducts.OnCartItemChanges += (c) => { OnCartItemChanges?.Invoke(c); };
            await ucProducts.SetData(null, false);
            pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(ucProducts);
            BackToDashboard = true;
        }


        async Task OpenOrders()
        {
            uctrlStoreOrders ucProducts = new uctrlStoreOrders();
            await ucProducts.LoadData(null);
            pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(ucProducts);
            BackToDashboard = true;
        }

        async Task OpenStores()
        {
            uctrlStores ucProducts = new uctrlStores();
            await ucProducts.LoadData();
            pnlContaner.Controls.Clear();
            pnlContaner.Controls.Add(ucProducts);
            BackToDashboard = true;
        }







        private async void lblBtnBack_Click(object sender, EventArgs e)
        {
            await Back();
        }

        async Task Back()
        {
            if (BackToDashboard)
            {
                pnlContaner.Controls.Clear();
                await LoadSummary();
                BackToDashboard = false;
            }
            else
                OnPressBack?.Invoke();
        }

    }
}
