using Shop_Desktop_Business.Other;
using Shop_Desktop_Business.Reviews;
using Shop_Desktop_Business.Seller;
using StoreHub_Desktop.User_Controls.Order;
using StoreHub_Desktop.User_Controls.Products.Reviews;
using StoreHub_DTOs.Reviews;
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

namespace StoreHub_Desktop.User_Controls.Seller.Reviews
{
    public partial class uctrl_StoreReviews : UserControl
    {
        public uctrl_StoreReviews()
        {
            InitializeComponent();
        }

        DTO_ReviewViewRequest request = new DTO_ReviewViewRequest();

        int _lastPageNumber = 0;


        int _storeId;

        public async Task LoadData(int storeId)
        {

            request.StoreId = storeId;
            request.PageNumber = 1;
            request.PageSize = 3;
            _storeId = storeId;
            request.PersonId = clsDefultes.LogendUser.person.PersonId;
            await LoadReviews();


        }

        async Task LoadReviews()
        {
            var reviews = await clsSeller.GetReviewsByStoreId(request);
            if (reviews != null)
            {
                int count = reviews.Reviews.Count;
                if (count > 0)
                {

                    lblShowingInfo.Text = $"Showing {count} of {reviews.AvalibleReviewsCount} reviews";
                    lblPageNumber.Text = $"Page Number: {request.PageNumber}";
                    fpnlOrders.Controls.Clear();
                    foreach (var rev in reviews.Reviews)
                    {

                        uctrl_MyReviewView uc = new uctrl_MyReviewView();
                        uc.SetData(rev);
                        uc.Margin = new Padding(10, 4, 10, 4);
                        fpnlOrders.Controls.Add(uc);
                    }
                   
                }
                else
                {
                    btnPrevoius.Visible = false;
                    btnNext.Visible = false;
                    btnPage1.Visible = false;
                    lblNoReviewsLineSammry.Visible = true;
                    lblNoReviesLine.Visible = true;
                }

                btnNext.Enabled = reviews.HasNextPage;

                btnPage2.Visible = request.PageNumber >= 2 || reviews.HasNextPage;


                _lastPageNumber = reviews.LastPageNumber;

                if (reviews.LastPageNumber > 2)
                {
                    btnLastPage.Visible = true;
                    btnLastPage.Text = reviews.LastPageNumber.ToString();
                    if (request.PageNumber != reviews.LastPageNumber)
                        btnLastPage.Enabled = true;


                }
                else
                    btnLastPage.Visible = false;

            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {

            request.PageNumber++;
            await LoadReviews();
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
            await LoadReviews();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await LoadReviews();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
        }

        private async void btnPage1_Click(object sender, EventArgs e)
        {

            request.PageNumber = 1;
            await LoadReviews();
            btnPrevoius.Enabled = false;

            btnPage1.Enabled = false;
            btnPage2.Enabled = true;
        }

        private async void btnPrevoius_Click(object sender, EventArgs e)
        {
            request.PageNumber--;
            await LoadReviews();
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
