using Shop_Desktop_Business.Admin;
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
    public partial class uctrl_AdminDashboardSummary : UserControl
    {
        public uctrl_AdminDashboardSummary()
        {
            InitializeComponent();
        }
        public Action BackToShopping;

        public Action OnClickOrders;
        public Action OnClickStores;
        public Action OnClickProducts;
        public Action OnClickUsers;
        public Action OnClickAddUsers;

        public async Task SetData()
        {
            var response = await clsAdmin.Dashboard();

            if (response == null)
                return;


            ucOrders.SetData(response.OrdersCount.ToString());
            ucStores.SetData(response.StoresCount.ToString());
            ucProducts.SetData(response.ProductsCount.ToString());
            ucUsers.SetData(response.UserCount.ToString());


            ucOrders.OnClickOrders += () => OnClickOrders?.Invoke();
            ucStores.OnClickStores += () => OnClickStores?.Invoke();
            ucProducts.OnClickProducts += () => OnClickProducts?.Invoke();
            ucUsers.OnClickUsers += () => OnClickUsers?.Invoke();


        }

        private void btnBackToShopping_Click(object sender, EventArgs e)
        {
            BackToShopping?.Invoke();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OnClickUsers?.Invoke();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            OnClickStores?.Invoke();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            OnClickOrders?.Invoke();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            OnClickProducts?.Invoke();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OnClickAddUsers?.Invoke();  
        }
    }
}
