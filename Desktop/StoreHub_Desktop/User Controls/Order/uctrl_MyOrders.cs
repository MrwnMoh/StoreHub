using Shop_Desktop_Business.Order;
using Shop_Desktop_Business.Other;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StoreHub_Desktop.User_Controls.Order
{
    public partial class uctrl_MyOrders : UserControl
    {

        public Action OnPerssBack;

        int _lastPageNumber;

        DTO_OrderViewMyRequest request = new DTO_OrderViewMyRequest();

        public uctrl_MyOrders()
        {
            InitializeComponent();
            request.PersonId = clsDefultes.LogendUser.person.PersonId;
            request.PageNumber = 1;
            request.PageSize = 3;
        }


        async Task SetData()
        {
            var orders = await clsOrder.ViewMyOrders(request);
            if (orders != null)
            {
                int count = orders.Orders.Count;
                if (count > 0)
                {

                    lblShowingInfo.Text = $"Showing {count} of {orders.AvalibleOrdersCount} orders";
                    fpnlOrders.Controls.Clear();
                    foreach (var order in orders.Orders)
                    {

                        uctrlOrderRowSummary uc = new uctrlOrderRowSummary();
                        uc.SetData(order);
                        uc.Margin = new Padding(10, 10, 10, 10);
                        fpnlOrders.Controls.Add(uc);
                    }

                }
                else
                {
                    btnPrevoius.Visible = false;
                    btnNext.Visible = false;
                    btnPage1.Visible = false;
                    lblNoReviesLine.Visible = true;
                    lblNoReviewsLineSammry.Visible = true;
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

        private void lblBtnBack_Click(object sender, EventArgs e)
        {
            OnPerssBack?.Invoke();
        }

        private async void uctrl_MyOrders_Load(object sender, EventArgs e)
        {
            await SetData();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            request.PageNumber++;
            await SetData();
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
            await SetData();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await SetData();

            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
        }

        private async void btnPage1_Click(object sender, EventArgs e)
        {
            request.PageNumber = 1;
            await SetData();
            btnPrevoius.Enabled = false;
            btnPage1.Enabled = false;
            btnPage2.Enabled = true;
        }

        private async void btnPrevoius_Click(object sender, EventArgs e)
        {
            request.PageNumber--;
            await SetData();
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
