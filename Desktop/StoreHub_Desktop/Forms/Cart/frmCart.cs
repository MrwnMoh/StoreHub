using Shop_Desktop_Business.Cart;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.User_Controls.Products;
using StoreHub_DTOs.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms.Cart
{
    public partial class frmCart : Form
    {

        public Action<int> OnCartCountChanges;

        decimal _toalAmount;
        int _itemsCount;
        public frmCart()
        {
            InitializeComponent();
        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frmCart_Load(object sender, EventArgs e)
        {
            await LoadCartData();
        }

        public async Task LoadCartData()
        {
            try
            {

                var cart = await GetCart();

                if(cart != null)
                {
                    _toalAmount = cart.TotalPrice;

                    _itemsCount = cart.CartItems.Count;
                    lblCartItemsCount.Text = $"({_itemsCount})";
                    lblTotalPrice.Text = _toalAmount.ToString("N2");


                    foreach (var item in cart.CartItems)
                    {
                        uctrlProductInCart uc = new uctrlProductInCart();
                        uc.SetData(item);
                        uc.OnIncreaseQuantiy += IncreaseTotalAmount;
                        uc.OnDecreaseQuantiy += DecreaseTotalAmount;
                        uc.OnDelete += DeleteItem;

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
            try
            {
                var cart = await clsCart.LoadCartByPersonId(clsDefultes.LogendUser.person.PersonId);

                return cart;
            }
            catch
            {
                throw;
            }
        }

        void IncreaseTotalAmount(decimal amount)
        {
            _toalAmount += amount;
            lblTotalPrice.Text = _toalAmount.ToString("N2");

        }

        void DecreaseTotalAmount(decimal amount)
        {
            _toalAmount -= amount;
            lblTotalPrice.Text = _toalAmount.ToString("N2");

        }


        void DeleteItem(Control item,decimal amount)
        {
            _toalAmount -= amount;
            _itemsCount--;
            OnCartCountChanges?.Invoke(_itemsCount);
            lblTotalPrice.Text = _toalAmount.ToString("N2");
            lblCartItemsCount.Text = $"({_itemsCount})";
            flpReviews.Controls.Remove(item);

        }


    }
}
