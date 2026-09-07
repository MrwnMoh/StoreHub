using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.User_Controls.Products.Category;
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

namespace StoreHub_Desktop.User_Controls.Products
{
    public partial class uctrlViewAllProducts : UserControl
    {
        public Action OnPressBack;

        public Action OnItemAddedToCart;
        public Action OnBuyNow;
        public Action<int> OnCartItemChanges;
        uctrlProductCategoryRow _previosSelectedCategoryUctrl;
        DTO_ProductsGetAll request = new DTO_ProductsGetAll();

        string? _searchFilter;

        int _lastPageNumber;

        int? _selectSpeasiolCategory = null;
        int _PreviousSortType = 0;

        public uctrlViewAllProducts()
        {
            InitializeComponent();

            request.PageNumber = 1;
            request.PageSize = 12;

            cmbSortByPrice.SelectedIndex = 0;

        }

        public async Task LoadProducts(int? categoryID = null,string? searchFilter = null)
        {
            await LoadCategories(categoryID);
            if (categoryID != null)
            {
                request.CategoryId = categoryID.Value;
                _selectSpeasiolCategory = categoryID;
            }
            else
            {
                request.CategoryId = 0;
                lblCategoryName.Text = "All Categories";
            }
            if(searchFilter != null)
            {
                _searchFilter = searchFilter;
                request.SearchFilter = _searchFilter;
            }
            try
            {

                request.SortBy = (DTO_ProductsGetAll.EProductSort)cmbSortByPrice.SelectedIndex;

                var products = await clsProducts.LoadAllProducts(request);


                if (products != null)
                {

                    lblProductsInfo.Text = $"Showing {products.Products.Count} of {products.AvalibleProductsCount} products";

                    btnNext.Enabled = products.HasNextPage;

                    btnPage2.Visible = request.PageNumber > 2 || products.HasNextPage;

                    _lastPageNumber = products.LastPageNumber;

                    if (products.LastPageNumber > 2)
                    {
                        btnLastPage.Visible = true;
                        btnLastPage.Text = products.LastPageNumber.ToString();
                        if (request.PageNumber != products.LastPageNumber)
                            btnLastPage.Enabled = true;


                    }
                    else
                        btnLastPage.Visible = false;


                        {
                            List<Control> controls = new List<Control>();

                            //await SetShowingInfo(products.Count);

                            foreach (var product in products.Products)
                            {
                                uctrlProductSamary uc = new uctrlProductSamary();

                                uc.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                                uc.OnBuyNow += () => OnBuyNow?.Invoke();
                                uc.OnCartItemChanges += (c) => OnCartItemChanges?.Invoke(c);
                                uc.Margin = new Padding(10, 8, 10, 0);

                                uc.SetData(product);


                                controls.Add(uc);
                                
                                

                            }
                            flpContaner.Controls.Clear();
                            flpContaner.Controls.AddRange(controls.ToArray());

                        }
                    }
            }
            catch (Exception ex)
            {
                clsUtilty.PrintWarn(ex.Message);
            }
        }

        private async void uctrlViewAllProducts_Load(object sender, EventArgs e)
        {
            //await LoadCategories(_selectSpeasiolCategory);
        }

        private async void cmbSortByPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortByPrice.SelectedIndex != _PreviousSortType)
            {
                cmbSortByPrice.Enabled = false;

                _PreviousSortType = cmbSortByPrice.SelectedIndex;

                request.SortBy = (DTO_ProductsGetAll.EProductSort)_PreviousSortType;

                ResetProducts();
                await LoadProducts(null,_searchFilter);
                cmbSortByPrice.Enabled = true;

            }
        }

        void ResetProducts()
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

        private async void btnNext_Click(object sender, EventArgs e)
        {
            request.PageNumber++;
            await LoadProducts();
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

        private async void btnPrevoius_Click(object sender, EventArgs e)
        {
            request.PageNumber--;
            await LoadProducts();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await LoadProducts();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
        }

        private async void btnPage1_Click(object sender, EventArgs e)
        {
            request.PageNumber = 1;
            await LoadProducts();
            btnPrevoius.Enabled = false;

            btnPage1.Enabled = false;
            btnPage2.Enabled = true;


        }

        private async void btnLastPage_Click(object sender, EventArgs e)
        {
            request.PageNumber = _lastPageNumber;
            await LoadProducts();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = true;
            btnLastPage.Enabled = false;
        }

        private void lblBtnBack_Click(object sender, EventArgs e)
        {
            OnPressBack?.Invoke();

        }


        async Task LoadCategories(int? categoryId)
        {
            fpnlOfCategories.Controls.Clear();
            await LoadAllCategorisCategory(categoryId);

            var categories = await clsProducts.GetProductCategories();

            if (categories != null)
            {
                foreach (var category in categories)
                {
                    uctrlProductCategoryRow uc = new uctrlProductCategoryRow();
                    uc.SetData(category);
                    uc.OnClickNewCategory += async (id) =>
                    {
                        _previosSelectedCategoryUctrl.SetToUnSelected();
                        uc.SetToSelected();
                        lblCategoryName.Text = category.Name;
                        await OnClickCategory(id, uc);
                    };
                    if (uc.category.ID == categoryId)
                       {
                        uc.SetToSelected();
                        _previosSelectedCategoryUctrl = uc;
                        lblCategoryName.Text = category.Name;
                        }
                    fpnlOfCategories.Controls.Add(uc);
                }

            }


        }

        async Task LoadAllCategorisCategory(int? categoryId)
        {

            uctrlProductCategoryRow uc = new uctrlProductCategoryRow();
            uc.OnClickNewCategory += async (id) =>
            {
                _previosSelectedCategoryUctrl.SetToUnSelected();
                uc.SetToSelected();
                await OnClickCategory(id, uc);
                lblCategoryName.Text = uc.category.Name;
            };

            if (categoryId == null || categoryId.HasValue && categoryId.Value == 0)
            {
                uc.SetToSelected();
                _previosSelectedCategoryUctrl = uc;
            }

            fpnlOfCategories.Controls.Add(uc);
        }

        async Task OnClickCategory(int clickedID, uctrlProductCategoryRow uc)
        {
            if (clickedID != request.CategoryId)
            {
                _previosSelectedCategoryUctrl.SetToUnSelected();
                fpnlOfCategories.Enabled = false;
                request.CategoryId = clickedID;
                ResetProducts();
                _searchFilter = "";
                await LoadProducts(clickedID, _searchFilter);
                _previosSelectedCategoryUctrl = uc;
                fpnlOfCategories.Enabled = true;

            }

        }



    }
}
