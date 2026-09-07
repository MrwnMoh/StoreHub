using Shop_Desktop_Business.Other;
using Shop_Desktop_Business.Seller;
using StoreHub_Desktop.Forms.Seller;
using StoreHub_DTOs.Store;
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
    public partial class uctrlStoreSammaryDashboard : UserControl
    {
        public uctrlStoreSammaryDashboard()
        {
            InitializeComponent();
        }

        public Action<int, bool> OnClickProducts;
        public Action<int> OnClickOrders;

        public Action<int> OnClickReviews;


        public Action BackToShopping;


        int id;
        public async Task SetData(int? storeId)
        {

            DTO_SellerGetStoreSammary store;

            if (storeId == null)
                store = await clsSeller.FirstStore(clsDefultes.LogendUser.person.PersonId);
            else
                store = await clsSeller.LoadStoreById(storeId.Value);

            if (store == null)
                return;

            uctrl_CurrentShop1.SetDataBy(store.StoreName, store.Description, store.StoreId);
            ucOrders.SetData(store.OrdersCount.ToString());
            ucProducts.SetData(store.ProductsCount.ToString());
            ucRevunes.SetData("$" + store.Revenue.ToString("N2"));
            id = store.StoreId;
        }

        private void uctrlStoreDashboard_Load(object sender, EventArgs e)
        {
            uctrl_CurrentShop1.LoadStore += async (c) => await SetData(c);
            ucProducts.OnClickProducts += () => OnClickProducts?.Invoke(id, false);
            ucOrders.OnClickOrders += () => OnClickOrders?.Invoke(id);

        }

        private async void btnStores_Click(object sender, EventArgs e)
        {
            frmChangeStoreOrAdd frm = new frmChangeStoreOrAdd(id);

            frm.LoadStore += async (c) => await SetData(c);

            frm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OnClickProducts?.Invoke(id, false);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OnClickProducts?.Invoke(id, true);

        }

        private void btnBackToShopping_Click(object sender, EventArgs e)
        {
            BackToShopping?.Invoke();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OnClickOrders?.Invoke(id);
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            OnClickReviews?.Invoke(id);
        }
    }
}
