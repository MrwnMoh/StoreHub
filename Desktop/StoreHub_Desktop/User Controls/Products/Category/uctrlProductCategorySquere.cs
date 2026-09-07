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
    public partial class uctrlProductCategorySquere : UserControl
    {

        public Action<int> OnClickCategory;

        public enum EProductCategories
        {
            Electronics = 1,

            Computers = 2,

            Furniture = 6,
            Shoes = 8,

            Health = 12,

            Grocery =13,

            Beverages = 14,
            Food = 15,

            Toys = 17,
            Books = 18,

            Automotive = 19,

          Other = 23,
        }

        public EProductCategories Category { get { return _category; } set { _category = value; ChangeCategory(); } }

        EProductCategories _category;

        int _count = 0;

        public uctrlProductCategorySquere()
        {
            InitializeComponent();

            OnClick(this);

            timer1.Interval = Random.Shared.Next(3,10) * 1000;
        }

        void OnClick(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                OnClick(ctrl);

                ctrl.Click += (s, e) => { OnClickCategory?.Invoke((int)_category); };

            }
        }

        void ChangeCategory()
        {
            switch (_category)
            {
                case EProductCategories.Electronics:
                    pnl.FillColor = Color.FromArgb(236, 237, 254);
                    break;

                case EProductCategories.Computers:
                    pnl.FillColor = Color.FromArgb(228, 245, 242);
                    break;

                case EProductCategories.Furniture:
                    pnl.FillColor = Color.FromArgb(247, 239, 229);
                    break;

                case EProductCategories.Shoes:
                    pnl.FillColor = Color.FromArgb(238, 240, 238);
                    break;

                case EProductCategories.Health:
                    pnl.FillColor = Color.FromArgb(232, 246, 239);
                    break;

                case EProductCategories.Grocery:
                    pnl.FillColor = Color.FromArgb(239, 247, 226);
                    break;

                case EProductCategories.Beverages:
                    pnl.FillColor = Color.FromArgb(229, 242, 250);
                    break;

                case EProductCategories.Food:
                    pnl.FillColor = Color.FromArgb(246, 238, 235);
                    break;

                case EProductCategories.Toys:
                    pnl.FillColor = Color.FromArgb(252, 239, 229);
                    break;

                case EProductCategories.Books:
                    pnl.FillColor = Color.FromArgb(240, 237, 250);
                    break;

                case EProductCategories.Automotive:
                    pnl.FillColor = Color.FromArgb(248, 235, 247);
                    break;

                case EProductCategories.Other:
                    pnl.FillColor = Color.FromArgb(234, 245, 252);
                    break;

                default:
                    pnl.FillColor = Color.FromArgb(242, 240, 254);
                    break;
            }

            lblCategoryName.Text = _category.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EProductCategories? newCategory = null;

                var categories = Enum.GetValues<EProductCategories>();

            do
            {
                int randomIndex = Random.Shared.Next(categories.Length);
                newCategory = (EProductCategories)categories[randomIndex];
            }
            while (newCategory == Category);
                Category = newCategory.Value;
        }

    }
}

