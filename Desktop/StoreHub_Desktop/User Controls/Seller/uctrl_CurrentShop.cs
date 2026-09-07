using StoreHub_Desktop.Forms.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Seller
{
    public partial class uctrl_CurrentShop : UserControl
    {
        public uctrl_CurrentShop()
        {
            InitializeComponent();
        }

        public Action<int> LoadStore;


        int id;

        public void SetDataBy(string StoreName, string? StoreDesciription, int storeId)
        {
            lblDescription.Text = StoreDesciription;
            lblShopName.Text = StoreName;

            id = storeId;
        }

        private void btnChangeShop_Click(object sender, EventArgs e)
        {
            frmChangeStoreOrAdd frm = new frmChangeStoreOrAdd(id);

            frm.LoadStore += (c) => LoadStore?.Invoke(c);

            frm.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
