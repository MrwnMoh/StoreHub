using Shop_Desktop_Business.Other;
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
    public partial class uctrlWriteAReview : UserControl
    {

        public Action<string, decimal> OnClickPost;

        public Action<DTO_ReviewsEdit> OnClickEdit;

        int _reviewId;

        bool _isUpdateReview = false;

        public uctrlWriteAReview()
        {
            InitializeComponent();
        }

        public void SetUserData()
        {
            lblName.Text = clsDefultes.LogendUser.person.FirstName + " " + clsDefultes.LogendUser.person.LastName;

            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        public void SetEditReviewData(DTO_ReviewsEdit edit)
        {
            _isUpdateReview = true;
            txbReview.Text = edit.ReviewText;
            guna2RatingStar1.Value = (float)edit.Rate;
            btnPost.Text = "Update Review";
            _reviewId = edit.ReviewID;
        }



        private void btnPost_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txbReview.Text))
            {
                if (_isUpdateReview)
                    OnClickEdit.Invoke(new DTO_ReviewsEdit{ Rate = (decimal)guna2RatingStar1.Value, ReviewText = txbReview.Text, ReviewID = _reviewId,PersonID = clsDefultes.LogendUser.person.PersonId });
                else
                OnClickPost?.Invoke(txbReview.Text, (decimal)guna2RatingStar1.Value);
            }
        }

        public void Clear()
        {
            txbReview.Clear();
            guna2RatingStar1.Value = 0;
            btnPost.Text = "Post Review";

        }

        private void txbReview_TextChanged(object sender, EventArgs e)
        {
            if(_isUpdateReview && txbReview.Text.Length == 0)
            {
                _isUpdateReview = false;
                Clear();
            }
        }
    }
}
