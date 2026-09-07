using Guna.UI2.WinForms;
using Shop_Desktop_Business.Seller;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Properties;
using StoreHub_DTOs.Products;
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

namespace StoreHub_Desktop.Forms.Seller
{
    public partial class frmAddEditProduct : Form
    {

        enum eMode
        {
            addNew,
            Edit
        }

        eMode _mode;

        public Action OnProductAdded;
        public Action<DTO_ProductsDetails> OnProductSaved;

        List<string> _ProductImagePathes = new();
        List<Guna2PictureBox> pictureBoxes = new List<Guna2PictureBox>();

        int _SeletectedImage;

        int _storeId;


        DTO_ProductsDetails _product;

        public frmAddEditProduct(DTO_ProductsDetails product, int storeId, List<string>? cateogriesList)
        {
            InitializeComponent();

            //_ProductId = Id;
            _storeId = storeId;
            _product = product;

            foreach (string category in cateogriesList)
            {
                cmbCategories.Items.Add(category);
            }
            cmbCategories.SelectedIndex = 0;

            pictureBoxes.Add(pbImage1);
            pictureBoxes.Add(pbImage2);
            pictureBoxes.Add(pbImage3);
            pictureBoxes.Add(pbImage4);

            SetData();
        }


        void SetData()
        {
            if (_product == null)
            {
                _mode = eMode.addNew;
                return;
            }

            _mode = eMode.Edit;
            lblCaption.Text = "Edit Product";

            txbDesciption.Text = _product.Description;
            txbPrice.Text = _product.Price.ToString("N2");
            txbProductName.Text = _product.ProductName;
            txbStockQuantity.Text = _product.StockQuantity.ToString();

            cmbCategories.SelectedItem = _product.CategoryName;
            _ProductImagePathes = new List<string>(_product.Images);
            if (_product.Images.Count != 0)
            {
                RefreshImages();
                _SeletectedImage = _ProductImagePathes.Count;
            }
        }

        private void OnClickAddImage(object sender, EventArgs e)
        {
            var pb = (Guna2PictureBox)sender;

            if (int.TryParse(pb.Tag.ToString(), out int tagNum))
            {
                _SeletectedImage = tagNum;
                if (_ProductImagePathes.Count >= tagNum)
                {
                    pbProductImage.Image = pb.Image;
                    return;
                }
            }

            openFileDialog1.Filter =
              "Image Files|*.jpg;*.jpeg;*.png;";

            openFileDialog1.Title = "Select Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgLockation = openFileDialog1.FileName;
                _ProductImagePathes.Add(imgLockation);
                pbProductImage.ImageLocation = imgLockation;

                RefreshImages();
            }

        }

        void ChangeImage(object sender)
        {


            openFileDialog1.Filter =
            "Image Files|*.jpg;*.jpeg;*.png;";

            openFileDialog1.Title = "Select Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string imgLockation = openFileDialog1.FileName;
                _ProductImagePathes[_SeletectedImage - 1] = imgLockation;
                pictureBoxes[_SeletectedImage - 1].ImageLocation = imgLockation;
                pbProductImage.ImageLocation = imgLockation;

            }

        }


        void RefreshImages()
        {

            int count = _ProductImagePathes.Count;

            for (int i = 0; i < count; i++)
            {
                pictureBoxes[i].Visible = true;
                pictureBoxes[i].ImageLocation = _ProductImagePathes[i];
            }

            for (int i = count; i < 4; i++)
            {
                pictureBoxes[i].Visible = false;
                pictureBoxes[i].Image = Resources.Plus;
            }


            if (count == 0)
            {
                pbProductImage.Image = Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
                pictureBoxes[0].Visible = true;


                btnDelete.Enabled = false;
                btnChangeImage.Enabled = false;
            }
            else
            {
                if (count < 4)
                    pictureBoxes[count].Visible = true;

                pbProductImage.ImageLocation = _ProductImagePathes.Last();

                btnDelete.Enabled = true;
                btnChangeImage.Enabled = true;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count = _ProductImagePathes.Count;
            if (_SeletectedImage <= count)
            {
                _ProductImagePathes.RemoveAt(_SeletectedImage - 1);
                RefreshImages();

                _SeletectedImage = count - 1;
            }

        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
        }



        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' || (txb.Text.Contains(".") && e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void txbPrice_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbPrice.Text, out decimal price))
            {
                txbPrice.Text = price.ToString("N2");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            await Save();
            btnSave.Enabled = true;
        }


        async Task Save()
        {
            if (_mode == eMode.Edit)
            {
                await SaveCurrentProduct();
            }
            else
            {
                await CreateNewProduct();
            }
        }

        async Task CreateNewProduct()
        {
            if (!IsTxbsOkay())
                return;

            if (_mode == eMode.Edit)
            {

            }
            DTO_SellerCreateNewProduct newProduct = new DTO_SellerCreateNewProduct();

            newProduct.ProductName = txbProductName.Text;
            newProduct.Description = txbDesciption.Text;

            if (decimal.TryParse(txbPrice.Text, out decimal Price))
            {
                newProduct.Price = Price;
            }
            else
                return;

            if (int.TryParse(txbStockQuantity.Text, out int stock))
            {
                newProduct.StockQuantity = stock;
            }
            else
                return;

            newProduct.CategoryId = cmbCategories.SelectedIndex + 1;

            newProduct.ProductImagePaths = GetNewPathes();

            newProduct.StoreId = _storeId;

            int productId = await clsSeller.CreateProduct(newProduct);
            if (productId == 0)
            {
                DeleteImages(newProduct.ProductImagePaths);
                clsUtilty.PrintWarn("Error while creating the prodcut");
                return;
            }
            else
            {
                clsUtilty.PrintInfo($"Prodcut created sucssfully whit id: {productId}");
                OnProductAdded?.Invoke();
                Close();
            }



        }

        void DeleteImages(List<string> pathes)
        {
            foreach (string path in pathes)
            {

                if (File.Exists(path))
                    File.Delete(path);
            }
        }

        async Task SaveCurrentProduct()
        {
            if (!IsTxbsOkay())
                return;

            _product.ProductName = txbProductName.Text;
            _product.Description = txbDesciption.Text;

            if (decimal.TryParse(txbPrice.Text, out decimal Price) && Price > 0)
            {
                _product.Price = Price;
                errorProvider1.SetError(txbPrice, "");
            }
            else
            {
                errorProvider1.SetError(txbPrice, "Please the price have to be number");
                return;
            }

            if (int.TryParse(txbStockQuantity.Text, out int stock) && stock >= 0)
            {
                _product.StockQuantity = stock;
                errorProvider1.SetError(txbStockQuantity, "");
            }
            else
            {
                errorProvider1.SetError(txbStockQuantity, "Please the stock have to be number");
                return;
            }

            _product.CategoryName = cmbCategories.SelectedItem.ToString() ?? "Other";

            DTO_SellerEditProduct request = new DTO_SellerEditProduct();


            if (IsImagesChanged())
            {
                var oldPaths = new List<string>(_product.Images);

                var newPaths = GetNewPathes();

                if (newPaths != null)
                {
                    DeleteOldImages(oldPaths, newPaths);

                    _product.Images = newPaths;

                }
            }


            request.ProductImagePaths = _product.Images;

            request.ProductId = _product.ProductId;
            request.ProductName = _product.ProductName;
            request.Description = _product.Description;
            request.Price = _product.Price;
            request.StockQuantity = _product.StockQuantity;
            request.CategoryId = cmbCategories.SelectedIndex + 1;

            bool res = await clsSeller.EditProduct(request);
            if (!res)
            {
                DeleteImages(request.ProductImagePaths);
                clsUtilty.PrintWarn("Error while saving the prodcut");
                return;
            }
            else
            {
                clsUtilty.PrintInfo($"Prodcut saved sucssfully");
                OnProductSaved?.Invoke(_product);
                Close();
            }



        }

        bool IsImagesChanged()
        {
            if (_product.Images.Count != _ProductImagePathes.Count)
                return true;


            for (int i = 0; i < _ProductImagePathes.Count; i++)
            {
                if (_ProductImagePathes[i] != _product.Images[i])
                    return true;
            }

            return false;
        }



        List<string> GetNewPathes()
        {
            List<string> newImagePathes = new List<string>();

            foreach (string path in _ProductImagePathes)
            {
                string newPath = "";
                if (clsUtilty.SaveImageToFileWithGuid(path, ref newPath, false))
                    newImagePathes.Add(newPath);
                else
                    return null;
            }


            return newImagePathes;
        }

        void DeleteOldImages(List<string> oldPaths, List<string> newPaths)
        {
            foreach (string oldPath in oldPaths)
            {
                if (!newPaths.Contains(oldPath))
                {
                    if (File.Exists(oldPath))
                        File.Delete(oldPath);
                }
            }
        }

        bool IsTxbsOkay()
        {
            bool accept = true;

            if (string.IsNullOrEmpty(txbPrice.Text))
            {
                errorProvider1.SetError(txbPrice, "Please enter the price");
                accept = false;
            }
            else
                errorProvider1.SetError(txbPrice, "");



            if (string.IsNullOrEmpty(txbStockQuantity.Text))
            {
                errorProvider1.SetError(txbStockQuantity, "Please enter the stock");
                accept = false;
            }
            else
                errorProvider1.SetError(txbStockQuantity, "");

            if (string.IsNullOrEmpty(txbProductName.Text))
            {
                errorProvider1.SetError(txbProductName, "Please enter the name");
                accept = false;
            }
            else
                errorProvider1.SetError(txbProductName, "");

            return accept;
        }

        private void lblBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
