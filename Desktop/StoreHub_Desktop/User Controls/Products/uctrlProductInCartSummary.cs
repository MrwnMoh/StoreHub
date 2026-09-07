using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
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

namespace StoreHub_Desktop.User_Controls.Products
{
    public partial class uctrlProductInCartSummary : UserControl
    {


        public uctrlProductInCartSummary()
        {
            InitializeComponent();
        }


        public void SetData(DTO_CartItem item)
        {
            lblPrice.Text = item.Price.ToString("N2");
            lblProductName.Text = item.ProductName;
            lblquantity.Text = item.Quantity.ToString();

            clsUtilty.LoadProductImage( pbProductImage, item.ImagePath);


        }

        public void SetData(DTO_OrderItem item)
        {
            lblPrice.Text = "$"+item.UnitPrice.ToString("N2");
            lblProductName.Text = item.ProductName;
            lblquantity.Text = item.Quantity.ToString();

            clsUtilty.LoadProductImage( pbProductImage, item.ImagePath);

        }


    }
}
