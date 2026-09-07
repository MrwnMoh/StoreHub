using Shop_Desktop_Business;
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
    public partial class frmLogout : Form
    {

        public Action OnLoggedOut;

        public frmLogout()
        {
            InitializeComponent();
        }

        private async void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogOut.Enabled = false;
            await Logout();
        }

        async Task Logout()
        {
            bool response = await clsPerson.Logout();

            if(response)
            {
                OnLoggedOut?.Invoke();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
