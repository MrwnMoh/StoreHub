using Shop_Desktop_Business.Cart;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.User_Controls.Products;
using StoreHub_DTOs.Cart;
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
    public partial class uctrlOrderSummary : UserControl
    {

        public decimal TotalPrice;

        public uctrlOrderSummary()
        {
            InitializeComponent();
        }

        public async Task LoadCartData()
        {
            try
            {

                var cart = await GetCart();

                if (cart != null)
                {
                    TotalPrice = cart.TotalPrice;

                    lblCartItemsCount.Text = $"({cart.CartItems.Count})";
                    lblTotalPrice.Text = "$" + TotalPrice.ToString("N2");


                    foreach (var item in cart.CartItems)
                    {
                        uctrlProductInCartSummary uc = new uctrlProductInCartSummary();
                        uc.SetData(item);

                        flpReviews.Controls.Add(uc);
                    }
                }

            }
            catch
            {
                throw;
            }
        }

        public async Task<DTO_Cart> GetCart()
        {
                var cart = await clsCart.LoadCartByPersonId(clsDefultes.LogendUser.person.PersonId);

                return cart;
        }

        public async Task LoadData(List<DTO_OrderItem> items,decimal totalAmount)
        {
            if (items == null)
                return;

            foreach (var item in items)
            {
                uctrlProductInCartSummary uc = new uctrlProductInCartSummary();
                uc.SetData(item);

                flpReviews.Controls.Add(uc);
            }

            lblCartItemsCount.Text = $"({items.Count})";
            lblTotalPrice.Text = "$" +totalAmount.ToString("N2");


        }


    }
}
