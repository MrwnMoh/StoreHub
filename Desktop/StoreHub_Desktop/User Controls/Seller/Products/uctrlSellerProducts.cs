using Shop_Desktop_Business.Products;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms.Seller;
using StoreHub_Desktop.User_Controls.Products;
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

namespace StoreHub_Desktop.User_Controls.Seller.Products
{
    public partial class uctrlSellerProducts : UserControl
    {

        int _PreviousSortType = 0;

        public Action OnItemAddedToCart;
        public Action OnBuyNow;

        public Action<int> OnCartItemChanges;
        public uctrlSellerProducts()
        {
            InitializeComponent();


        }

        DTO_ProductsGetAll request = new DTO_ProductsGetAll();

        List<string> _Categories = new List<string>();

        int _lastPageNumber;

        async Task LoadCategories()
        {
            var categories = await clsProducts.GetProductCategories();

            if (categories != null)
            {
                _Categories.AddRange(categories.Select(c=> c.Name).ToList());

                foreach (var category in categories)
                {
                    cmbCategories.Items.Add(category.Name);
                }

            }

        }

        async Task LoadProducts()
        {
            try
            {

                request.SortBy = (DTO_ProductsGetAll.EProductSort)cmbSortByPrice.SelectedIndex;

                var products = await clsProducts.LoadAllProducts(request);


                if (products != null)
                {

                    //lblProductsInfo.Text = $"Showing {products.Products.Count} of {products.AvalibleProductsCount} products";

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

                    lblPageNumber.Text = $"Page Number: {request.PageNumber}";

                    //await SetShowingInfo(products.Count);

                    List<Control> contrlos = new List<Control>();
                    foreach (var product in products.Products)
                    {
                        uctrl_SellerProductRow uc = new uctrl_SellerProductRow();
                        uc.OnBuyNow += () => OnBuyNow?.Invoke();
                        uc.OnItemAddedToCart += () => OnItemAddedToCart?.Invoke();
                        uc.OnClcikEdit += () => uc.OpenEdit(_Categories);
                        uc.OnCartItemChanges += (c) => { OnCartItemChanges?.Invoke(c); };
                        uc.ProductDeleted += () => { flpProducts.Controls.Remove(uc); uc.Dispose(); };
                        uc.SetData(product);
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

        public async Task SetData(int? StoreID,bool addProduct)
        {
            request.StoreId = StoreID;
            if (!request.StoreId.HasValue)
            {
                btnAddProduct.Enabled = false;
                btnAddProduct.Visible = false;
            }


            cmbSortByPrice.SelectedIndex = 4;
            cmbCategories.SelectedIndex = 0;

            request.PageSize = 5;
            request.PageNumber = 1;


            request.SortBy = DTO_ProductsGetAll.EProductSort.LastProdcuts;

            await LoadCategories();


            if (addProduct)
            {
                await AddProduct();
                return;
            }

            await LoadProducts();


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

        private async void btnPage1_Click(object sender, EventArgs e)
        {
            request.PageNumber = 1;
            await LoadProducts();
            btnPrevoius.Enabled = false;

            btnPage1.Enabled = false;
            btnPage2.Enabled = true;
        }

        private async void btnPage2_Click(object sender, EventArgs e)
        {
            request.PageNumber = 2;
            await LoadProducts();
            btnPrevoius.Enabled = true;
            btnPage1.Enabled = true;
            btnPage2.Enabled = false;
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


        private async void cmbSortByPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortByPrice.SelectedIndex != _PreviousSortType)
            {
                cmbSortByPrice.Enabled = false;

                _PreviousSortType = cmbSortByPrice.SelectedIndex;

                request.SortBy = (DTO_ProductsGetAll.EProductSort)_PreviousSortType;

                ResetProducts();
                await LoadProducts();
                cmbSortByPrice.Enabled = true;

            }
        }

        private async void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategories.Enabled = false;
            request.CategoryId = cmbCategories.SelectedIndex;
            ResetProducts();
            await LoadProducts();
            cmbCategories.Enabled = true;

        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            await AddProduct();
        }

        async Task AddProduct()
        {
            if (!request.StoreId.HasValue)
                return;
            frmAddEditProduct frm = new frmAddEditProduct(null, request.StoreId.Value, _Categories);
            frm.OnProductAdded += async () => { await LoadProducts(); };
            frm.ShowDialog();
        }

    }
}
