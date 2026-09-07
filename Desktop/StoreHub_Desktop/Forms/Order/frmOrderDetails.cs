using Shop_Desktop_Business.Order;
using Shop_Desktop_Business.Other;
using Shop_Desktop_Business.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Order
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private async void frmOrderDetails_Load(object sender, EventArgs e)
        {
        }


        public async Task LoadData(int orderId,int? storeId = null)
        {

            var order = new StoreHub_DTOs.Order.DTO_OrderDetails();
            order = null;
            if (storeId != null)
                order = await clsSeller.GetOrderDetailsForStore(new StoreHub_DTOs.Store.DTO_SellerGetOrderDetailsForStore { OrderId = orderId, StoreId = storeId.Value });
            else
            order = await clsOrder.GetOrderDetails(orderId);

            if (order == null)
                return;

            uctrlOrderStatus1.Status = (uctrlOrderStatus.eStatus)order.OrderStatusID;
            lblSippingAdress.Text = order.ShippingAddress;


            uctrlOrderSummary1.LoadData(order.Items, order.TotalAmount);


        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
