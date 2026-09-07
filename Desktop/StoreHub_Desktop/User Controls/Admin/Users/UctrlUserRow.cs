using Shop_Desktop_Business.Admin;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Admin;
using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Admin.Users
{
    public partial class UctrlUserRow : UserControl
    {
        public UctrlUserRow()
        {
            InitializeComponent();
        }


        int personId;

        DTO_PersonSummary _person;

        public void SetData(DTO_PersonSummary personSummary)
        {
            lblEmail.Text = personSummary.Email;
            lblPhone.Text = personSummary.Phone;
            lblUserFullName.Text = personSummary.FirstName + " " + personSummary.LastName;
            clsUtilty.LoadUserImage(ref pbUserPic, personSummary.UserImagePath, personSummary.IsMale);

            ucIsActive.Status = personSummary.IsActive;
            btnNotActive.Enabled = personSummary.IsActive;
            ucIsSeller.Status = personSummary.IsSeller;
            ucIsAdmin.Status = personSummary.IsAdmin;
            ucIsMale.Status = personSummary.IsMale;

            personId = personSummary.PersonId;

            _person = personSummary;
        }
   
        private async void btnNotActive_Click(object sender, EventArgs e)
        {
            btnNotActive.Enabled = false;
            await NotActive();
        }

        async Task NotActive()
        {
            await clsAdmin.NotActive(personId);
            ucIsActive.Status = false;
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            await Edit();
        }

        async Task Edit()
        {
            frmAddEditUser frm = new frmAddEditUser(personId);
            await frm.LoadData(_person);
            frm.OnSaved += (ps) => SetData(ps);
            frm.ShowDialog();
        }


    }
}
