using Shop_Desktop_Business.Cart;
using StoreHub_Desktop.Forms.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms.Global
{
    public partial class frmProductAddedToCart : Form
    {

        public Action OnClickViewCart;

        public frmProductAddedToCart()
        {
            InitializeComponent();
        }


        public async Task SetData(int productId)
        {
            await uctrlProductSamary1.SetDataById(productId);

            int quantity = await clsCart.GetItemQuantity(productId);

            lblQuantity.Text = quantity.ToString();

        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {

            Hide();
            OnClickViewCart?.Invoke();
            
            Close();
        }
    }
}
