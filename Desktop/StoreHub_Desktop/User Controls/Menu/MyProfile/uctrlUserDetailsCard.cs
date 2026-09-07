using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Menu.MyProfile
{
    public partial class uctrlUserDetailsCard : UserControl
    {
        public uctrlUserDetailsCard()
        {
            InitializeComponent();
        }

        public void SetData()
        {

            lblUserName.Text = $"{clsDefultes.LogendUser.person.FirstName} {clsDefultes.LogendUser.person.LastName}";
            clsUtilty.LoadUserImage(ref picUserPic, clsDefultes.LogendUser.person.ImagePath, clsDefultes.LogendUser.person.IsMale);
            lblEmail.Text = clsDefultes.LogendUser.person.Email;
            lblAdress.Text = clsDefultes.LogendUser.person.Address;
            lblphone.Text = clsDefultes.LogendUser.person.Phone;
            lblCountry.Text = clsDefultes.LogendUser.person.CountryName;
        }


    }
}
