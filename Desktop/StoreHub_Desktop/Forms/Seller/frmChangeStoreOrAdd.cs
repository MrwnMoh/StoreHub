using Shop_Desktop_Business.Seller;
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
using Guna.UI2.WinForms;

namespace StoreHub_Desktop.Forms.Seller
{
    public partial class frmChangeStoreOrAdd : Form
    {

        int _currentStoreId;

        public Action<int> LoadStore;

        public frmChangeStoreOrAdd(int currentStoreId)
        {
            InitializeComponent();

            _currentStoreId = currentStoreId;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }



        async Task LoadStores()
        {
            var stores = await clsSeller.LoadStoresNameAndId(clsDefultes.LogendUser.person.PersonId);

            if (stores == null)
                return;

            foreach (var st in stores)
            {
                Guna2GradientButton btn = new Guna2GradientButton();
                btn.Size = btnBack.Size;
                btn.Font = btnBack.Font;
                btn.BorderRadius = btnBack.BorderRadius;
                btn.Animated = true;

                btn.Text = st.StoreName;
                btn.Tag = st.Id;

                if (st.Id == _currentStoreId)
                {
                    btn.FillColor = Color.FromArgb(95, 77, 214);
                    btn.FillColor2 = Color.FromArgb(63, 41, 202);
                    btn.ForeColor = Color.White;
                    btn.Click += (s, e) => Close();

                }
                else
                {
                    btn.FillColor = btnBack.FillColor;
                    btn.FillColor2 = btnBack.FillColor2;
                    btn.ForeColor = btnBack.ForeColor;

                    btn.Click += (s, e) => { LoadStore?.Invoke(st.Id); Close(); };
                }
                fpblStores.Controls.Add(btn);

            }



        }

        private async void frmChangeStoreOrAdd_Load(object sender, EventArgs e)
        {
            await LoadStores();
        }

        private void btnCreateNewStore_Click(object sender, EventArgs e)
        {
            Hide();
            frmCreateStore frmCreateStore = new frmCreateStore();
            frmCreateStore.OnStoreCreated += (id) => LoadStore?.Invoke(id);
            frmCreateStore.ShowDialog();
            Close();
        }
    }
}
