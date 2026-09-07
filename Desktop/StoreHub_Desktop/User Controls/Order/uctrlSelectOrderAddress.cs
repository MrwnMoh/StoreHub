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

namespace StoreHub_Desktop.User_Controls.Order
{
    public partial class uctrlSelectOrderAddress : UserControl
    {

        string pfpAdress;


        public uctrlSelectOrderAddress()
        {
            InitializeComponent();
        }

        private void rbtnPfpAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPfpAddress.Checked)
                { 
                rdbtDiffrentAdress.Checked = false;

                }
        }

        private void rdbtDiffrentAdress_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtDiffrentAdress.Checked)
                {
                    rbtnPfpAddress.Checked = false;
                }


            txbAddress.Enabled = rdbtDiffrentAdress.Checked;

        }


        void SetData()
        {
            lblName.Text = clsDefultes.LogendUser.person.FirstName + " " + clsDefultes.LogendUser.person.LastName;
            lblAddress.Text = clsDefultes.LogendUser.person.Address;
            lblPhone.Text = clsDefultes.LogendUser.person.Phone;


        }

        private void uctrlSelectOrderAddress_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            pfpAdress = clsDefultes.LogendUser.person.Address;

            SetData();
        }

        public string GetAddress()
        {
            if (rbtnPfpAddress.Checked)
                return pfpAdress;
            else
                return txbAddress.Text;
        }

    }
}
