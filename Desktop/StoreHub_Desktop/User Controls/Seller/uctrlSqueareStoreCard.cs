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

namespace StoreHub_Desktop.User_Controls.Seller
{
    public partial class uctrlSqueareStoreCard : UserControl
    {

        public Action OnClickProducts;

        public Action OnClickOrders;


        public enum ECardTypes
        {
            Products,
            Orders,
            Revenue
        }

        public ECardTypes Type { get { return _CardType; } set { _CardType = value; ChangeType(); } }

        ECardTypes _CardType = ECardTypes.Products;



        public uctrlSqueareStoreCard()
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
                case ECardTypes.Revenue:
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
                case ECardTypes.Revenue:
                    lblCardLine.Text = "Total Sales";
                    pbCardImage.Image = Resources.Revenue;
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
