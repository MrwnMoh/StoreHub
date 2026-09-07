using Shop_Desktop_Business.Order;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
using StoreHub_DTOs.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Order
{
    public partial class uctrlCheckOut : UserControl
    {

        public Action OnPressBack;
        public Action OnOrderPlaced;

        string ShippingAdress = clsDefultes.LogendUser.person.Address;

        public uctrlCheckOut()
        {
            InitializeComponent();
        }

        private async void uctrlCheckOut_Load(object sender, EventArgs e)
        {
            await uctrlOrderSummary1.LoadCartData();
            btnCheckout.Enabled = true;

        }

        private void lblBtnBack_Click(object sender, EventArgs e)
        {
            //Hide();
            OnPressBack?.Invoke();
        }

        private async void btnCheckout_Click(object sender, EventArgs e)
        {
            await PlaceOrder();
        }

        async Task PlaceOrder()
        {

            ShippingAdress = uctrlSelectOrderAddress2.GetAddress();

            if (string.IsNullOrEmpty(ShippingAdress))
            {
                clsUtilty.PrintWarn("Please enter your address");
                return;
            }
            try
            {
                btnCheckout.Enabled = false;

                DTO_OrderPlace order = new DTO_OrderPlace();
                order.PersonID = clsDefultes.LogendUser.person.PersonId;
                order.ShippingAddress = ShippingAdress;
                order.TotalAmount = uctrlOrderSummary1.TotalPrice;

                int orderId = await clsOrder.PlaceOrder(order);

                if (orderId > 0)
                {
                    clsUtilty.PrintInfo($"Your order has been placed successfully,\nWith ID {orderId}");
                    OnOrderPlaced?.Invoke();
                    return;
                }
                btnCheckout.Enabled = true;

            }
            catch
            {
                throw;
            }
        }


    }
}
