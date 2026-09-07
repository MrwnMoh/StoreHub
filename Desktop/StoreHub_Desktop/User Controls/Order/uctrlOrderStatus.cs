using StoreHub_Desktop.Properties;
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
    public partial class uctrlOrderStatus : UserControl
    {
        public uctrlOrderStatus()
        {
            InitializeComponent();
        }


        public enum eStatus
        {
            Pending=1,
            Processing = 3,
            Shipped,
            Delivered,
            Cancelled

        }

        public eStatus Status { get { return _status; } set { _status = value; ChangeStatus(); } }

        eStatus _status = eStatus.Pending;

        void ChangeStatus()
        {
            switch (Status)
            {
                case eStatus.Pending:
                    btnStatus.FillColor = Color.FromArgb(254, 244, 225);
                    btnStatus.FillColor2 = Color.FromArgb(254, 244, 225);
                    btnStatus.ForeColor = Color.FromArgb(252, 131, 19);
                    btnStatus.BorderColor = Color.FromArgb(252, 131, 19);
                    btnStatus.Image = Resources.ChatGPT_Image_Aug_23__2026__07_09_24_PM__3_;
                    break;
                case eStatus.Processing:
                    btnStatus.FillColor = Color.FromArgb(232, 242, 255);
                    btnStatus.FillColor2 = Color.FromArgb(232, 242, 255);
                    btnStatus.ForeColor = Color.FromArgb(37, 99, 235);
                    btnStatus.BorderColor = Color.FromArgb(37, 99, 235);
                    btnStatus.Image = Resources.Processing;
                    break;
                case eStatus.Shipped:
                    btnStatus.FillColor = Color.FromArgb(239, 235, 255);
                    btnStatus.FillColor2 = Color.FromArgb(239, 235, 255);
                    btnStatus.ForeColor = Color.FromArgb(99, 76, 255);
                    btnStatus.BorderColor = Color.FromArgb(99, 76, 255);
                    btnStatus.Image = Resources.Shipped;
                    break;
                case eStatus.Delivered:
                    btnStatus.FillColor = Color.FromArgb(232, 247, 235);
                    btnStatus.FillColor2 = Color.FromArgb(232, 247, 235);
                    btnStatus.ForeColor = Color.FromArgb(22, 163, 74);
                    btnStatus.BorderColor = Color.FromArgb(22, 163, 74);
                    btnStatus.Image = Resources.Delivered;
                    break;
                case eStatus.Cancelled:
                    btnStatus.FillColor = Color.FromArgb(255, 235, 235);
                    btnStatus.FillColor2 = Color.FromArgb(255, 235, 235);
                    btnStatus.ForeColor = Color.FromArgb(239, 68, 68);
                    btnStatus.BorderColor = Color.FromArgb(239, 68, 68);
                    btnStatus.Image = Resources.Cancelled;
                    break;
                default:
                    break;
            }


            btnStatus.Text = Status.ToString();

        }


    }
}
