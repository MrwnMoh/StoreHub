using StoreHub_DTOs.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Products.Category
{
    public partial class uctrlProductCategoryRow : UserControl
    {

        public DTO_Category category= new DTO_Category { ID = 0,Name = "All Categories"};

        public Action<int> OnClickNewCategory;


        public uctrlProductCategoryRow()
        {
            InitializeComponent();
            OnClick(this);

        }


        void OnClick(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                OnClick(ctrl);

                ctrl.Click += (s,e) => { OnClickNewCategory?.Invoke(category.ID); };

            }
        }

        public void SetData(DTO_Category _category)
        {
            category.ID = _category.ID;
            category.Name = _category.Name;
            lblCategoryName.Text = category.Name;
        }

        public void SetToSelected()
        {

            pnl.FillColor = Color.FromArgb(242, 240, 254);
            lblCategoryName.ForeColor = Color.FromArgb(63, 41, 202);
        
        }

        public void SetToUnSelected()
        {

            pnl.FillColor = Color.Transparent;
            lblCategoryName.ForeColor = Color.FromArgb(46, 55, 68);

        }

    }
}
