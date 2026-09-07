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
    public partial class uctrlIsActive : UserControl
    {
        public uctrlIsActive()
        {
            InitializeComponent();
        }

     
        public bool Status { get { return _Status; } set { _Status = value; ChangeStatus(); } }

        bool _Status;



        void ChangeStatus()
        {
            switch (_Status)
            {
                case true:
                    guna2Panel1.FillColor = Color.FromArgb(224, 247, 236);
                    lblStatus.ForeColor = Color.FromArgb(34, 120, 80);
                    lblStatus.Text = "Yes";
                    break;
                case false:
                    guna2Panel1.FillColor = Color.FromArgb(255, 232, 232);
                    lblStatus.ForeColor = Color.FromArgb(190, 60, 60);
                    lblStatus.Text = "No";
                    break;
                default:
                    break;
            }



        }






    }
}
