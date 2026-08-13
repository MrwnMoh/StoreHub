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

        public Action<Control,decimal> OnDelete;


        int _quantity;
        int _itemId;

        bool _checkQuantity = false;
        bool _OffInrease = false;

        decimal _price;

        public uctrlProductInCart()
        {
            InitializeComponent();
        }

        void OffTextInNumaric(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    break;
                }
            }
        }

        public void SetData(DTO_CartItem item)
        {
            lblPrice.Text = item.Price.ToString("N2");
            lblProductName.Text = item.ProductName;

            nmcQuantity.Value = item.Quantity;
            _quantity = item.Quantity;
            _itemId = item.ItemID;

            clsUtilty.SetProductImage(ref pbProductImage, item.ImagePath);

            _price = item.Price;
            _checkQuantity = true;
            OffTextInNumaric(nmcQuantity);

        }


        private async void nmcQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (_checkQuantity)
            {
                nmcQuantity.Enabled = false;
                if (nmcQuantity.Value > _quantity)
                {

                    if (!_OffInrease)
                    {
                        bool res = await clsCart.IncreaseQuantity(_itemId);

                        if (res)
                        {
                            OnIncreaseQuantiy?.Invoke(_price);
                        }
                        else
                        {
                            nmcQuantity.Value--;
                            nmcQuantity.Maximum = _quantity;
                            _OffInrease = true;
                            clsUtilty.PrintWarn("No stock available from this seller");

                        }
                    }
                    else
                    {
                        nmcQuantity.Value--;
                        clsUtilty.PrintWarn("No stock available from this seller");
                    }

                }
                else
                {

                    await clsCart.DecreaseItemQuantity(_itemId);

                    _OffInrease = false;
                    OnDecreaseQuantiy.Invoke(_price);
                }
                nmcQuantity.Enabled = true;

                _quantity = (int)nmcQuantity.Value;
            }



        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await Delete();
            OnDelete?.Invoke(this,_price * _quantity);
        }

        async Task Delete()
        {
            await clsCart.DeleteItem(_itemId);
        }


    }
}
