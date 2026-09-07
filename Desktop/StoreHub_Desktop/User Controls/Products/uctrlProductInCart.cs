using Shop_Desktop_Business.Cart;
using StoreHub_Desktop.Classes;
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

namespace StoreHub_Desktop.User_Controls.Products
{

    public partial class uctrlProductInCart : UserControl
    {
        public Action<decimal> OnIncreaseQuantiy;
        public Action<decimal> OnDecreaseQuantiy;

        public Action<Control, decimal> OnDelete;


        int _quantity;
        int _itemId;
        bool _noMoreStock = false;

        decimal _price;

        public uctrlProductInCart()
        {
            InitializeComponent();
        }
        public void SetData(DTO_CartItem item)
        {
            lblPrice.Text = item.Price.ToString("N2");
            lblProductName.Text = item.ProductName;

            _quantity = item.Quantity;
            _itemId = item.ItemID;


            clsUtilty.LoadProductImage(pbProductImage, item.ImagePath);

            _price = item.Price;


            lblQuantity.Text = _quantity.ToString();
            if (_quantity > 0)
                BtnNegtave.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            BtnNegtave.Enabled = false;
            btnDelete.Enabled = false;
            await Delete();
            OnDelete?.Invoke(this, _price * _quantity);
            BtnNegtave.Enabled = true;
            btnDelete.Enabled = true;
        }

        async Task Delete()
        {
            await clsCart.DeleteItem(_itemId);
        }

        private async void btnPlus_Click(object sender, EventArgs e)
        {
            btnPlus.Enabled = false;
            BtnNegtave.Enabled = false;
            btnDelete.Enabled = false;
            if (!_noMoreStock)
            {
                bool res = await clsCart.IncreaseQuantity(_itemId);

                if (res)
                {
                    OnIncreaseQuantiy?.Invoke(_price);
                    btnPlus.Enabled = true;
                    _quantity++;

                    lblQuantity.Text = _quantity.ToString();
                }
                else
                {
                    _noMoreStock = true;
                    clsUtilty.PrintWarn("No stock available from this seller");
                }
            }
            else
            {
                clsUtilty.PrintWarn("No stock available from this seller");
            }

            BtnNegtave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private async void BtnNegtave_Click(object sender, EventArgs e)
        {
            BtnNegtave.Enabled = false;
            btnPlus.Enabled = false;
            btnDelete.Enabled = false;
            if (_quantity > 0)
            {
                await clsCart.DecreaseItemQuantity(_itemId);
                _noMoreStock = false;
                OnDecreaseQuantiy.Invoke(_price);

                _quantity--;
                lblQuantity.Text = _quantity.ToString();
                BtnNegtave.Enabled = true;
            }
            btnPlus.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
