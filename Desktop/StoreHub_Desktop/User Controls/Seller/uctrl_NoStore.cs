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
    public partial class uctrl_NoStore : UserControl
    {

        public Action<int> OnStoreCreated {  get; set; }
        public uctrl_NoStore()
        {
            InitializeComponent();
        }

        private void btnCreateStore_Click(object sender, EventArgs e)
        {
            frmCreateStore frmCreateStore = new frmCreateStore();
            frmCreateStore.OnStoreCreated += (id) => OnStoreCreated?.Invoke(id);
            frmCreateStore.ShowDialog();
        }

        async Task CreateStore()
        {

        }


    }
}
