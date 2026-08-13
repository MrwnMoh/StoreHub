using Shop_Desktop_Business.Cart;
using Shop_Desktop_Business.Other;
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

namespace StoreHub_Desktop.Forms
{
    public partial class frmMainApp : Form
    {
        public frmMainApp()
        {
            InitializeComponent();
        }


        async Task LoadData()
        {
            await homeProducts1.LoadHomeProducts();
            await LoadCartItemsCount(null);
            homeProducts1.OnItemAddedToCart += async () => {await LoadCartItemsCount(null); };
            homeProducts1.OnCartItemChanges += async (c) => {await LoadCartItemsCount(c); };
        }

        async Task LoadCartItemsCount(int? count)
        {
            if(count ==null)
            {
                count = await clsCart.CartItemsCount(clsDefultes.LogendUser.person.PersonId);
            }
            lblCartItemsCount.Text = count.ToString();
        }

        private async void frmMainApp_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenCart();
        }

        void OpenCart()
        {
            frmCart frm  = new frmCart();
            frm.OnCartCountChanges += async (count) => {

                await LoadCartItemsCount(count);
            };
            frm.ShowDialog();
        }

    }
}
