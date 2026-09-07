using Shop_Desktop_Business.Order;
using Shop_Desktop_Business.Seller;
using StoreHub_Desktop.User_Controls.Order;
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

namespace StoreHub_Desktop.User_Controls.Seller.Orders
{
    public partial class uctrlStoreOrders : UserControl
    {
        public uctrlStoreOrders()
        {
            InitializeComponent();
        }

        DTO_SellerStoreOrdersRequest request = new DTO_SellerStoreOrdersRequest();

        int _lastPageNumber = 0;


        int? _storeId;

        public async Task LoadData(int? storeId)
        {

            request.StoreId = storeId;
            request.PageNumber = 1;
            request.PageSize = 4;
            _storeId = storeId;
            await LoadOrders();


        }

        async Task LoadOrders()
        {
            var orders = await clsSeller.StoreOrders(request);
            if (orders != null)
            {
                int count = orders.Orders.Count;
                if (count > 0)
                {

                    lblShowingInfo.Text = $"Showing {count} of {orders.AvalibleOrdersCount} orders";
                    lblPageNumber.Text = $"Page Number: {request.PageNumber}";
                    fpnlOrders.Controls.Clear();
                    foreach (var order in orders.Orders)
                    {

                        uctrlOrderRowSummary uc = new uctrlOrderRowSummary();
                        uc.SetData(order, _storeId);
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

                btnNext.Enabled = orders.HasNextPage;

                btnPage2.Visible = request.PageNumber >= 2 || orders.HasNextPage;


                _lastPageNumber = orders.LastPageNumber;

                if (orders.LastPageNumber > 2)
                {
                    btnLastPage.Visible = true;
                    btnLastPage.Text = orders.LastPageNumber.ToString();
                    if (request.PageNumber != orders.LastPageNumber)
                        btnLastPage.Enabled = true;


                }
                else
                    btnLastPage.Visible = false;

            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {

            request.PageNumber++;
            await LoadOrders();
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
            await LoadOrders();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await LoadOrders();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
        }

        private async void btnPage1_Click(object sender, EventArgs e)
        {

            request.PageNumber = 1;
            await LoadOrders();
            btnPrevoius.Enabled = false;

            btnPage1.Enabled = false;
            btnPage2.Enabled = true;
        }

        private async void btnPrevoius_Click(object sender, EventArgs e)
        {
            request.PageNumber--;
            await LoadOrders();
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
