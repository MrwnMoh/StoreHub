using Shop_Desktop_Business.Order;
using StoreHub_Desktop.Classes;
using StoreHub_DTOs.Order;
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
    public partial class uctrlOrderRowSummary : UserControl
    {
        public uctrlOrderRowSummary()
        {
            InitializeComponent();
        }

        int id;
        int? _storeId;
        int _statusId;
        public void SetData(DTO_OrderSummary order, int? storeId = null)
        {
            lblOrderDate.Text = order.OrderDate.ToShortDateString();
            lblOrderHour.Text = order.OrderDate.ToShortTimeString();
            lblOrderItems.Text = order.ItemsCount.ToString() + " Items";
            lblOrderNumber.Text = $"Order #{order.OrderNumber}";
            lblOrderTotal.Text = order.TotalAmount.ToString("N2");
            uctrlOrderStatus1.Status = (uctrlOrderStatus.eStatus)order.OrderStatusId;
            id = order.OrderNumber;
            _statusId = order.OrderStatusId;
            if (_statusId != 1)
                btnDelete.Enabled = false;

            _storeId = storeId;


            if (storeId == null)
            {
                cxmsOrderStatus.Enabled = false;
                cxmsOrderStatus.Visible = false;
            }


        }

        private async void btnViewDetails_Click(object sender, EventArgs e)
        {
            btnViewDetails.Enabled = false;
            frmOrderDetails frm = new frmOrderDetails();
            if (_storeId != null)
                await frm.LoadData(id, _storeId);
            else
                await frm.LoadData(id);
            frm.ShowDialog();
            btnViewDetails.Enabled = true;

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            if (_statusId == 1)
            {
                bool res = await clsOrder.CancelOrder(id);

                if (res)
                {
                    uctrlOrderStatus1.Status = (uctrlOrderStatus.eStatus)6;
                    return;
                }
                else
                {
                    clsUtilty.PrintWarn("Error While canceling the order");
                }
                btnDelete.Enabled = true;
            }
            else
            {
                clsUtilty.PrintWarn("Only pending orders can be cancelled.");
            }
        }

        private async void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ChangeStatus(3);
        }

        async Task ChangeStatus(int statusId)
        {
            cxmsOrderStatus.Enabled = false;

            bool res = await clsOrder.ChangeOrderStatus(new DTO_OrderChangeStatus { OrderId = id, StatusId = statusId });

            if (res)
            {
                btnDelete.Enabled = false;
                _statusId = statusId;
                uctrlOrderStatus1.Status = (uctrlOrderStatus.eStatus)_statusId;
            }
            else
            {
                clsUtilty.PrintWarn("Error while changing the order status");
            }
            cxmsOrderStatus.Enabled = true;

        }

        private async void shippedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            await ChangeStatus(4);
        }

        private async void deliveredToolStripMenuItem_Click(object sender, EventArgs e)
        {

            await ChangeStatus(5);
        }

        private void cxmsOrderStatus_Opening(object sender, CancelEventArgs e)
        {
            if (_storeId == null || _statusId == 6 || _statusId == 5)
                e.Cancel = true;

            switch (_statusId)
            {
                case 3: // Processing
                    processingToolStripMenuItem.Visible = false;
                    shippedToolStripMenuItem.Visible = true;
                    break;

                case 4: // Shipped
                    processingToolStripMenuItem.Visible = false;
                    shippedToolStripMenuItem.Visible = false;
                    break;

                case 5: // Delivered
                    processingToolStripMenuItem.Visible = false;
                    shippedToolStripMenuItem.Visible = false;
                    break;
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
