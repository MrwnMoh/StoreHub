using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Global;
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
    public partial class uctrlUserReview : UserControl
    {


        DTO_ReviewsEdit _Redit;


        public Action<DTO_ReviewsEdit> OnEditReview;
        public Action OnDeleteReview;


        public uctrlUserReview()
        {
            InitializeComponent();
        }


        public void SetData(DTO_Reviews review)
        {
            _Redit = new DTO_ReviewsEdit();
            _Redit.ReviewText = review.ReviewText;
            _Redit.Rate = review.Rating;
            _Redit.ReviewID = review.ReviewID;
            _Redit.PersonID = review.PersonID;

            lblEdited.Visible = review.Edited;

            lblName.Text = review.UserFullName;
            lblReviewText.Text = review.ReviewText;
            lblDate.Text = review.Date.ToShortDateString();
            guna2RatingStar1.Value = (float)review.Rating;


            clsUtilty.LoadUserImage(ref guna2CirclePictureBox1, review.UserImagePath, review.IsUserMale);

        }

        private void lblDotsBtnInfo_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (_Redit.PersonID != clsDefultes.LogendUser.person.PersonId)
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEditReview?.Invoke(_Redit);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void Delete()
        {
            frmDelete frm = new frmDelete();
            frm.DeleteType = frmDelete.eDeleteType.Review;
            frm._ReviewDtoDelete = new DTO_ReviewsDelete { ReviewId =_Redit.ReviewID,PersonId = _Redit.PersonID };
            frm.OnDeleted += () => { OnDeleteReview?.Invoke(); frm.Close(); };
            frm.Show();
        }

    }
}
