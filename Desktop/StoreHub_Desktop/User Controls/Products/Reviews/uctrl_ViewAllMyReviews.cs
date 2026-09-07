using Shop_Desktop_Business;
using Shop_Desktop_Business.Other;
using Shop_Desktop_Business.Reviews;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Products.Reviews
{
    public partial class uctrl_ViewAllMyReviews : UserControl
    {

        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        public Action<int> OnCartItemChanges;

        public Action OnPressBack;
        int _lastPageNumber;

        DTO_ReviewViewRequest request = new DTO_ReviewViewRequest();


        public uctrl_ViewAllMyReviews()
        {
            InitializeComponent();

            request.PersonId = clsDefultes.LogendUser.person.PersonId;
            request.PageNumber = 1;
            request.PageSize = 3;
        }


        public async Task SetData()
        {

            var reviews = await clsReviews.GetReviewsByPersonId(request);

            if (reviews != null)
            {
                int count = reviews.Reviews.Count;
                if (count > 0)
                {
                    lblShowingInfo.Text = $"Showing {count} of {reviews.AvalibleReviewsCount} reviews";

                    List<Control> controls = new List<Control>();
                    foreach (var review in reviews.Reviews)
                    {
                        uctrl_MyReviewView uc = new uctrl_MyReviewView();

                        uc.OnBuyNow += () => OnBuyNow?.Invoke();
                        uc.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                        uc.OnCartItemChanges += (c) => { OnCartItemChanges?.Invoke(c); };

                        uc.SetData(review);
                        controls.Add(uc);
                    }
                    fpnlReviews.Controls.Clear();
                    fpnlReviews.Controls.AddRange(controls.ToArray());

                }
                else
                {
                    btnPrevoius.Visible = false;
                    btnNext.Visible = false;
                    btnPage1.Visible = false;
                    lblNoReviesLine.Visible = true;
                    lblNoReviewsLineSammry.Visible = true;
                }

                btnNext.Enabled = reviews.HasNextPage;

                btnPage2.Visible = request.PageNumber > 2 || reviews.HasNextPage;


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

        private void lblBtnBack_Click(object sender, EventArgs e)
        {
            OnPressBack?.Invoke();
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

        private async void btnLastPage_Click(object sender, EventArgs e)
        {
            request.PageNumber = _lastPageNumber;
            await SetData();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
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
