using Shop_Desktop_Business.Cart;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Cart;
using StoreHub_Desktop.Forms.Global;
using StoreHub_Desktop.Forms.Menu;
using StoreHub_Desktop.User_Controls.Admin;
using StoreHub_Desktop.User_Controls.Menu;
using StoreHub_Desktop.User_Controls.Order;
using StoreHub_Desktop.User_Controls.Products;
using StoreHub_Desktop.User_Controls.Products.Reviews;
using StoreHub_Desktop.User_Controls.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms
{
    public partial class frmMainApp : Form
    {

        uctrlViewAllProducts ucViewAllProducts = new uctrlViewAllProducts();
        frmMenu _frmMenu = new frmMenu();
        frmLogin _frmLogin = new frmLogin();


        public frmMainApp(frmLogin loginFrm)
        {
            InitializeComponent();


            _frmLogin = loginFrm;
        }


        async Task LoadData()
        {
            await homeProducts1.LoadHomeProducts();
            await LoadCartItemsCount(null);
            homeProducts1.OnItemAddedToCart += async () => { await LoadCartItemsCount(null); };
            homeProducts1.OnCartItemChanges += async (c) => { await LoadCartItemsCount(c); };
            homeProducts1.OnViewAllProduct += async () => { await OpenViewAllProduct(); };
            homeProducts1.OnBuyNow += async () => await Checkout();
            bigBanner1.OnClick += async (id) => { await OpenViewAllProduct(id); };
            uctrlProductCategorySquere1.OnClickCategory += async (id) => { await OpenViewAllProduct(id); };
            uctrlProductCategorySquere2.OnClickCategory += async (id) => { await OpenViewAllProduct(id); };
            uctrlProductCategorySquere3.OnClickCategory += async (id) => { await OpenViewAllProduct(id); };
            uctrlProductCategorySquere4.OnClickCategory += async (id) => { await OpenViewAllProduct(id); };
            uctrlProductCategorySquere5.OnClickCategory += async (id) => { await OpenViewAllProduct(id); };
            uctrlProductSearch1.OnSearch += async (text) => { await OpenViewAllProduct(0, text); };
            ucViewAllProducts.OnBuyNow += async () => await Checkout();
        }

        void SetUserData()
        {
            SetLoggendUser();
            OnClickOnUser(pnlUserInfo);

            _frmMenu.OnClickMyProfile += async () => await OpenProfile();
            _frmMenu.OnClickMyOrders += async () => await OpenMyOrders();
            _frmMenu.OnClickLogOut += OpenLogOut;
            _frmMenu.OnClickSellerDashboard += async () => await SellerDashboard();
            _frmMenu.OnClickMyReviews += async () => {await OpenMyReviews();};
            _frmMenu.OnClickAdminDashboard += async () => {await OpenAdminDashboard();};

        }

        void SetLoggendUser()
        {
            lblUserName.Text = $"{clsDefultes.LogendUser.person.FirstName} {clsDefultes.LogendUser.person.LastName}";
            clsUtilty.LoadUserImage(ref picUserPic, clsDefultes.LogendUser.person.ImagePath, clsDefultes.LogendUser.person.IsMale);
        }

        async Task SellerDashboard()
        {
            _frmMenu.Close();
            GroupPanel.Controls.Clear();

            uctrl_Seller_MainDashboard uc = new uctrl_Seller_MainDashboard();
            uc.OnPressBack += async () =>
            {
                await ShowHomeAgain();
                GroupPanel.Controls.Remove(uc);
                uc.Dispose();
            };
            uc.OnItemAddedToCart += async () => { await LoadCartItemsCount(null); };
            uc.OnCartItemChanges += async (c) => { await LoadCartItemsCount(c); };
            uc.OnBuyNow += async () => await Checkout();
            uc.SetData();
            GroupPanel.Controls.Add(uc);

        }

        async Task OpenProfile()
        {
            _frmMenu.Close();
            GroupPanel.Controls.Clear();

            uctrlMyProfile uc = new uctrlMyProfile();
            uc.OnEdit += () => { SetLoggendUser(); };
            uc.OnPressBack += async () =>
            {
                await ShowHomeAgain();
                GroupPanel.Controls.Remove(uc);
                uc.Dispose();
            };
            GroupPanel.Controls.Add(uc);

        }

        async Task OpenMyReviews()
        {
            _frmMenu.Close();

            uctrl_ViewAllMyReviews uc = new uctrl_ViewAllMyReviews();
            uc.OnPressBack += async () =>
            {
                await ShowHomeAgain();
                GroupPanel.Controls.Remove(uc);
                uc.Dispose();
            };
            uc.OnItemAddedToCart += async () => { await LoadCartItemsCount(null); };
            uc.OnCartItemChanges += async (c) => { await LoadCartItemsCount(c); };
            uc.OnBuyNow += async () => await Checkout();
            await uc.SetData();
            GroupPanel.Controls.Clear();
            GroupPanel.Controls.Add(uc);
        }

        async Task OpenAdminDashboard()
        {
            _frmMenu.Close();

            uctrl_AdminMainDashboard uc = new uctrl_AdminMainDashboard();
            uc.OnPressBack += async () =>
            {
                await ShowHomeAgain();
                GroupPanel.Controls.Remove(uc);
                uc.Dispose();
            };
            //uc.OnItemAddedToCart += async () => { await LoadCartItemsCount(null); };
            //uc.OnCartItemChanges += async (c) => { await LoadCartItemsCount(c); };
            //uc.OnBuyNow += async () => await Checkout();
            await uc.LoadData();
            GroupPanel.Controls.Clear();
            GroupPanel.Controls.Add(uc);
        }


        async Task OpenMyOrders()
        {
            _frmMenu.Close();
            GroupPanel.Controls.Clear();

            uctrl_MyOrders uc = new uctrl_MyOrders();
            uc.OnPerssBack += async () =>
            {
                await ShowHomeAgain();
                GroupPanel.Controls.Remove(uc);
                uc.Dispose();
            };
            GroupPanel.Controls.Add(uc);

        }


        void OpenUserMenu()
        {

            _frmMenu.StartPosition = FormStartPosition.Manual;
            _frmMenu.Location = Cursor.Position;

            _frmMenu.ShowDialog();


        }

        void OpenLogOut()
        {
            frmLogout frm = new frmLogout();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.OnLoggedOut += HandelLogOut;
            frm.ShowDialog();

        }

        void HandelLogOut()
        {
            clsDefultes.AccessToken = "";
            this.Close();
            _frmLogin.Show();
        }

        async Task ShowHomeAgain()
        {
            await homeProducts1.LoadHomeProducts();
            GroupPanel.Controls.Add(pnlHome);
            pnlHome.Location = new Point(6, 5);
        }

        async Task LoadCartItemsCount(int? count)
        {
            if (count == null)
            {
                count = await clsCart.CartItemsCount(clsDefultes.LogendUser.person.PersonId);
            }
            lblCartItemsCount.Text = count.ToString();
        }

        private async void frmMainApp_Load(object sender, EventArgs e)
        {
            SetUserData();
            await LoadData();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenCart();
        }

        void OpenCart()
        {
            frmCart frm = new frmCart();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = Cursor.Position;
            frm.OnCartCountChanges += async (count) =>
            {

                await LoadCartItemsCount(count);
            };
            frm.OnCheckout += async () => await Checkout();
            frm.ShowDialog();
        }


        async Task Checkout()
        {

            GroupPanel.Controls.Clear();

            uctrlCheckOut uc = new uctrlCheckOut();
            uc.OnPressBack += async () =>
            {

                await ShowHomeAgain();
                uc.Dispose();
            };

            uc.OnOrderPlaced += () =>
            {

                lblCartItemsCount.Text = "0";
            };

            GroupPanel.Controls.Add(uc);
        }

        async Task OpenViewAllProduct(int? categoryId = null, string? searchFilter = null)
        {

            

            await ucViewAllProducts.LoadProducts(categoryId, searchFilter);

            if(!GroupPanel.Contains(ucViewAllProducts))
                GroupPanel.Controls.Clear();

            ucViewAllProducts.OnPressBack += async () =>
            {
                await ShowHomeAgain();
                GroupPanel.Controls.Remove(ucViewAllProducts);
            };
            ucViewAllProducts.OnItemAddedToCart += async () => { await LoadCartItemsCount(null); };
            ucViewAllProducts.OnCartItemChanges += async (c) => { await LoadCartItemsCount(c); };

            GroupPanel.Controls.Add(ucViewAllProducts);
        }


        void OnClickOnUser(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                OnClickOnUser(ctrl);

                ctrl.Click += (s, e) => OpenUserMenu();

            }
        }

        private async void lblProframeNameBtnBackToHome_Click(object sender, EventArgs e)
        {
            if(!GroupPanel.Controls.Contains(pnlHome))
            {
                GroupPanel.Controls.Clear();
                await ShowHomeAgain();
            }
        }
    }
}
