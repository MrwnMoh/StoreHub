using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Admin.Stores
{
    public partial class uctrlStoreRow : UserControl
    {
        public uctrlStoreRow()
        {
            InitializeComponent();
        }


        public void SetData(DTO_StoreDetails data)
        {
            lblStoreId.Text = data.Id.ToString();

            lblStoreName.Text = data.StoreName;

            lblStoreOwnerFullName.Text = data.StoreOwnerName;

            lblORdersCount.Text = data.OrdersCount.ToString();

            lblProductsCount.Text = data.ProductsCount.ToString();

            lblREviewnu.Text = "$" + data.Revenu.ToString("N2");

        }



    }
}
