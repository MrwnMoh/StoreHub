using Shop_Desktop_Business.Admin;
using Shop_Desktop_Business.Seller;
using StoreHub_Desktop.User_Controls.Order;
using StoreHub_DTOs.Admin;
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

namespace StoreHub_Desktop.User_Controls.Admin.Stores
{
    public partial class uctrlStores : UserControl
    {
        public uctrlStores()
        {
            InitializeComponent();
        }

        DTO_GetStoresSummarysRequest request = new DTO_GetStoresSummarysRequest();

        int _lastPageNumber = 0;

        public async Task LoadData()
        {

            request.PageNumber = 1;
            request.PageSize = 4;
            await LoadStores();


        }

        async Task LoadStores()
        {
            var Stores = await clsAdmin.Stores(request);
            if (Stores != null)
            {
                int count = Stores.Stores.Count;
                if (count > 0)
                {

                    lblShowingInfo.Text = $"Showing {count} of {Stores.AvalibleOrdersCount} stores";
                    lblPageNumber.Text = $"Page Number: {request.PageNumber}";
                    fpnlOrders.Controls.Clear();
                    foreach (var Store in Stores.Stores)
                    {

                        uctrlStoreRow uc = new uctrlStoreRow();
                        uc.SetData(Store);
                        uc.Margin = new Padding(10, 4, 10, 4);
                        fpnlOrders.Controls.Add(uc);
                    }

                }
                else
                {
                    btnPrevoius.Visible = false;
                    btnNext.Visible = false;
                    btnPage1.Visible = false;
                }

                btnNext.Enabled = Stores.HasNextPage;

                btnPage2.Visible = request.PageNumber >= 2 || Stores.HasNextPage;


                _lastPageNumber = Stores.LastPageNumber;

                if (Stores.LastPageNumber > 2)
                {
                    btnLastPage.Visible = true;
                    btnLastPage.Text = Stores.LastPageNumber.ToString();
                    if (request.PageNumber != Stores.LastPageNumber)
                        btnLastPage.Enabled = true;


                }
                else
                    btnLastPage.Visible = false;

            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {

            request.PageNumber++;
            await LoadStores();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;

            if (request.PageNumber > 2)
            {
                btnPage2.Enabled = true;
            }
            else
                btnPage2.Enabled = false;

            if (request.PageNumber == _lastPageNumber)
            {
                btnLastPage.Enabled = false;
            }
        }

        private async void btnLastPage_Click(object sender, EventArgs e)
        {
            request.PageNumber = _lastPageNumber;
            await LoadStores();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await LoadStores();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
        }

        private async void btnPage1_Click(object sender, EventArgs e)
        {

            request.PageNumber = 1;
            await LoadStores();
            btnPrevoius.Enabled = false;

            btnPage1.Enabled = false;
            btnPage2.Enabled = true;
        }

        private async void btnPrevoius_Click(object sender, EventArgs e)
        {
            request.PageNumber--;
            await LoadStores();
            btnNext.Enabled = true;
            btnLastPage.Enabled = true;

            if (request.PageNumber <= 1)
            {
                btnPrevoius.Enabled = false;
                btnPage1.Enabled = false;
            }
            if (request.PageNumber == 2)
                btnPage2.Enabled = false;
            else
                btnPage2.Enabled = true;
        }





    }
}
