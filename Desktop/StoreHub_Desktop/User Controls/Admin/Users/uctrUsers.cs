using Microsoft.VisualBasic.ApplicationServices;
using Shop_Desktop_Business.Admin;
using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Admin;
using StoreHub_Desktop.User_Controls.Seller.Products;
using StoreHub_DTOs.Admin;
using StoreHub_DTOs.People;
using StoreHub_DTOs.Products;
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
    public partial class uctrUsers : UserControl
    {
        public uctrUsers()
        {
            InitializeComponent();
        }
        int _PreviousSortType = 0;

        int _lastPageNumber;


        DTO_AdminGetUsersRequest request = new DTO_AdminGetUsersRequest();


        async Task LoadUsers()
        {
            try
            {

                request.Filter = (DTO_AdminGetUsersRequest.eFilter)cmbFilters.SelectedIndex;

                var Users = await clsAdmin.Users(request);


                if (Users != null)
                {

                    //lblProductsInfo.Text = $"Showing {products.Products.Count} of {products.AvalibleProductsCount} products";

                    btnNext.Enabled = Users.HasNextPage;

                    btnPage2.Visible = request.PageNumber > 2 || Users.HasNextPage;
                    btnPage2.Enabled = btnPage2.Visible;

                    _lastPageNumber = Users.LastPageNumber;
                    int count = Users.Users.Count;

                    lblShowingInfo.Text = $"Showing {count} of {Users.AvalibleUsersCount} user";

                    if (Users.LastPageNumber > 2)
                    {
                        btnLastPage.Visible = true;
                        btnLastPage.Text = Users.LastPageNumber.ToString();
                        if (request.PageNumber != Users.LastPageNumber)
                            btnLastPage.Enabled = true;


                    }
                    else
                        btnLastPage.Visible = false;

                    lblPageNumber.Text = $"Page Number: {request.PageNumber}";

                    //await SetShowingInfo(products.Count);

                    List<Control> contrlos = new List<Control>();
                    foreach (var user in Users.Users)
                    {
                        UctrlUserRow uc = new UctrlUserRow();
                        uc.SetData(user);
                        contrlos.Add(uc);
                    }
                    flpProducts.Controls.Clear();
                    flpProducts.Controls.AddRange(contrlos.ToArray());
                }
            }
            catch (Exception ex)
            {
                clsUtilty.PrintWarn(ex.Message);
            }


        }

        void AddUser(DTO_PersonSummary person)
        {
            UctrlUserRow uc = new UctrlUserRow();
            uc.SetData(person);
            flpProducts.Controls.Add(uc);
        }

        public async Task SetData(bool addUser = false)
        {

            cmbFilters.SelectedIndex = 0;

            request.PageSize = 5;
            request.PageNumber = 1;

            request.Filter = DTO_AdminGetUsersRequest.eFilter.Mix;


            if (addUser)
            {
                await AddUser();
                return;
            }

            await LoadUsers();


        }

        private async void btnPrevoius_Click(object sender, EventArgs e)
        {
            request.PageNumber--;
            await LoadUsers();
            btnNext.Enabled = true;
            btnLastPage.Enabled = true;

            if (request.PageNumber <= 1)
            {
                btnPrevoius.Enabled = false;
                btnPage1.Enabled = false;
            }
            if (request.PageNumber == 2)
                btnPage2.Enabled = false;
            else
                btnPage2.Enabled = true;
        }

        private async void btnPage1_Click(object sender, EventArgs e)
        {
            request.PageNumber = 1;
            await LoadUsers();
            btnPrevoius.Enabled = false;

            btnPage1.Enabled = false;
            btnPage2.Enabled = true;
        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await LoadUsers();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
        }

        private async void btnLastPage_Click(object sender, EventArgs e)
        {
            request.PageNumber = _lastPageNumber;
            await LoadUsers();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            request.PageNumber++;
            await LoadUsers();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;

            if (request.PageNumber > 2)
            {
                btnPage2.Enabled = true;
            }
            else
                btnPage2.Enabled = false;

            if (request.PageNumber == _lastPageNumber)
            {
                btnLastPage.Enabled = false;
            }
        }

        void ResetUsers()
        {
            request.PageNumber = 1;
            btnPage1.Enabled = false;
            btnLastPage.Enabled = true;
            btnPrevoius.Enabled = false;

            if (_lastPageNumber > 2)
            {
                btnPage2.Enabled = true;
            }

        }

        private async void cmbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilters.SelectedIndex != _PreviousSortType)
            {
                cmbFilters.Enabled = false;

                _PreviousSortType = cmbFilters.SelectedIndex;

                request.Filter = (DTO_AdminGetUsersRequest.eFilter)_PreviousSortType;

                ResetUsers();
                await LoadUsers();
                cmbFilters.Enabled = true;

            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddUser();
        }


        async Task AddUser()
        {
            frmAddEditUser frm = new frmAddEditUser(null);
            await frm.LoadData(null);
            frm.OnSaved += (newPerson) => AddUser(newPerson);
            frm.ShowDialog();  
        }






    }
}
