using Shop_Desktop_Business.Other;
using Shop_Desktop_Business.Seller;
using StoreHub_Desktop.Classes;
using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms.Seller
{
    public partial class frmCreateStore : Form
    {
        public frmCreateStore()
        {
            InitializeComponent();
        }

        public Action<int> OnStoreCreated;

        private async void btnCreateStore_Click(object sender, EventArgs e)
        {
            btnCreateStore.Enabled = false;
            await CreateStore();
        }

        async Task CreateStore()
        {

            if (string.IsNullOrWhiteSpace(txbStoreName.Text))
            {
                clsUtilty.PrintWarn("Please enter the store name");
                btnCreateStore.Enabled = true;
                return;
            }

            DTO_SellerCreateStoreRequest request = new DTO_SellerCreateStoreRequest();

            request.PersonId = clsDefultes.LogendUser.person.PersonId;
            request.StoreName = txbStoreName.Text;
            request.Description = txbDescription.Text == null ? null : txbDescription.Text;

            int storeId = await clsSeller.CreateStore(request);
            if (storeId == 0)
            {
                clsUtilty.PrintWarn("Error while creating the store");
                btnCreateStore.Enabled = true;
                return;
            }

            clsDefultes.LogendUser.person.IsSeller = true;
            clsUtilty.PrintInfo($"Store created sucssfully whit id: {storeId}");
            OnStoreCreated?.Invoke(storeId);
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
