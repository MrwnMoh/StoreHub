using Guna.UI2.WinForms;
using Shop_Desktop_Business.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public Action OnClickMyProfile;

        public Action OnClickMyOrders;
        public Action OnClickMyReviews;

        public Action OnClickLogOut;

        public Action OnClickSellerDashboard;
        public Action OnClickAdminDashboard;


        Guna2GradientButton _prevBtn;

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            var btn = (Guna2GradientButton)sender;
            SetToSelected(btn);

            OnClickMyProfile?.Invoke();


            if (_prevBtn != null)
                SetToUnSelected(_prevBtn);
            _prevBtn = btn;

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            var btn = (Guna2GradientButton)sender;
            SetToSelected(btn);

            OnClickMyOrders?.Invoke();


            if (_prevBtn != null)
                SetToUnSelected(_prevBtn);
            _prevBtn = btn;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_prevBtn != null)
                SetToUnSelected(_prevBtn);

            this.Close();
            OnClickLogOut?.Invoke();



        }

        void SetToSelected(Guna2GradientButton btn)
        {

            btn.FillColor = Color.FromArgb(242, 240, 254);
            btn.FillColor2 = Color.FromArgb(242, 240, 254);
            btn.ForeColor = Color.FromArgb(63, 41, 202);

        }

        void SetToUnSelected(Guna2GradientButton btn)
        {

            btn.FillColor = Color.Transparent;
            btn.FillColor2 = Color.Transparent;
            btn.ForeColor = Color.Black;

        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            var btn = (Guna2GradientButton)sender;
            SetToSelected(btn);

            OnClickMyReviews?.Invoke();


            if (_prevBtn != null)
                SetToUnSelected(_prevBtn);
            _prevBtn = btn;
        }

        private void btnSellerDashboard_Click(object sender, EventArgs e)
        {
            var btn = (Guna2GradientButton)sender;
            SetToSelected(btn);

            OnClickSellerDashboard?.Invoke();


            if (_prevBtn != null)
                SetToUnSelected(_prevBtn);
            _prevBtn = btn;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnAdminDashboard.Visible = clsDefultes.LogendUser.person.IsAdmin;
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            var btn = (Guna2GradientButton)sender;
            SetToSelected(btn);

            OnClickAdminDashboard?.Invoke();


            if (_prevBtn != null)
                SetToUnSelected(_prevBtn);
            _prevBtn = btn;
        }
    }
}
