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

namespace StoreHub_Desktop.User_Controls.Admin
{
    public partial class uctrl_AdminAnalisesSquare : UserControl
    {

        public enum ECardTypes
        {
            Products,
            Orders,
            Users,
            Stores
        }

        public ECardTypes Type { get { return _CardType; } set { _CardType = value; ChangeType(); } }

        ECardTypes _CardType = ECardTypes.Products;

        public Action OnClickProducts;

        public Action OnClickOrders;
        public Action OnClickStores;
        public Action OnClickUsers;



        public uctrl_AdminAnalisesSquare()
        {
            InitializeComponent();
            OnClick(this);
        }

        void OnClick(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                OnClick(ctrl);

                ctrl.Click += (s, e) => { OnClick(); };

            }
        }

        void OnClick()
        {
            switch (_CardType)
            {
                case ECardTypes.Products:
                    OnClickProducts?.Invoke();
                    break;
                case ECardTypes.Orders:
                    OnClickOrders?.Invoke();
                    break;
                case ECardTypes.Stores:
                    OnClickStores?.Invoke();
                    break;
                case ECardTypes.Users:
                    OnClickUsers?.Invoke();
                    break;
                default:
                    break;
            }
        }


        void ChangeType()
        {

            lblCardName.Text = _CardType.ToString();

            switch (_CardType)
            {
                case ECardTypes.Products:
                    lblCardLine.Text = "Total Products";
                    pbCardImage.Image = Resources.Products;
                    break;
                case ECardTypes.Orders:
                    lblCardLine.Text = "Total Orders";
                    pbCardImage.Image = Resources.Shipped;
                    break;
                case ECardTypes.Stores:
                    lblCardLine.Text = "Total Stores";
                    pbCardImage.Image = Resources.Store;
                    break;
                case ECardTypes.Users:
                    lblCardLine.Text = "Total Users";
                    pbCardImage.Image = Resources.Users;
                    break;
                default:
                    break;
            }
        }

        public void SetData(string data)
        {
            lblContanint.Text = data;
        }




    }
}
