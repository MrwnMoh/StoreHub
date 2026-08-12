using Shop_Desktop_Business;
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

namespace StoreHub_Desktop.Forms.Global
{
    public partial class frmDelete : Form
    {

        public Action OnDeleted;

        public DTO_ReviewsDelete _ReviewDtoDelete;
        public enum eDeleteType
        {

            Person,
            Review

        }

        public eDeleteType DeleteType { get { return _deleteType; } set { _deleteType = value; ChangeType(); } }

        eDeleteType _deleteType = eDeleteType.Person;

        public frmDelete()
        {
            InitializeComponent();
        }

        void ChangeType()
        {
            lblDeleteType.Text = _deleteType.ToString();


            switch (_deleteType)
            {
                case eDeleteType.Person:
                    break;
                case eDeleteType.Review:
                    break;
                default:
                    break;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            btnDelete.Enabled= false;
            await Delete();
            btnDelete.Enabled = true;
        }

        async Task Delete()
        {

            try
            {
                await clsProducts.DeleteAReview(_ReviewDtoDelete);
                OnDeleted?.Invoke();
            }
            catch
            {
                throw;
            }
        }

    }
}
