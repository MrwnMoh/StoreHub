namespace StoreHub_Desktop.User_Controls.Products
{
    partial class uctrlProductSamary
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            lblProductName = new Label();
            lblProductCategory = new Label();
            lblPrice = new Label();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnBuyNow = new Guna.UI2.WinForms.Guna2GradientButton();
            btnAddToCart = new Guna.UI2.WinForms.Guna2GradientButton();
            lblRatingAvg = new Label();
            lblTotalRating = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbProductImage
            // 
            pbProductImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbProductImage.BorderRadius = 15;
            pbProductImage.CustomizableEdges = customizableEdges9;
            pbProductImage.Image = Properties.Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
            pbProductImage.ImageRotate = 0F;
            pbProductImage.Location = new Point(33, 34);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pbProductImage.Size = new Size(279, 183);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.White;
            lblProductName.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(46, 55, 68);
            lblProductName.Location = new Point(14, 264);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(141, 25);
            lblProductName.TabIndex = 15;
            lblProductName.Text = "Product Name";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.BackColor = Color.White;
            lblProductCategory.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductCategory.ForeColor = Color.DarkGray;
            lblProductCategory.Location = new Point(14, 304);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(144, 21);
            lblProductCategory.TabIndex = 16;
            lblProductCategory.Text = "Product Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(14, 331);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(61, 30);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Price";
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(14, 367);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.RatingColor = Color.FromArgb(250, 192, 96);
            guna2RatingStar1.ReadOnly = true;
            guna2RatingStar1.Size = new Size(141, 28);
            guna2RatingStar1.TabIndex = 18;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.FromArgb(239, 240, 243);
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(btnBuyNow);
            guna2Panel1.Controls.Add(btnAddToCart);
            guna2Panel1.Controls.Add(lblRatingAvg);
            guna2Panel1.Controls.Add(lblTotalRating);
            guna2Panel1.Controls.Add(guna2RatingStar1);
            guna2Panel1.Controls.Add(lblPrice);
            guna2Panel1.Controls.Add(lblProductCategory);
            guna2Panel1.Controls.Add(lblProductName);
            guna2Panel1.Controls.Add(pbProductImage);
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.Size = new Size(351, 447);
            guna2Panel1.TabIndex = 1;
            // 
            // btnBuyNow
            // 
            btnBuyNow.Animated = true;
            btnBuyNow.BorderColor = Color.FromArgb(239, 240, 243);
            btnBuyNow.BorderRadius = 4;
            btnBuyNow.BorderThickness = 1;
            btnBuyNow.CustomizableEdges = customizableEdges11;
            btnBuyNow.DisabledState.BorderColor = Color.DarkGray;
            btnBuyNow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuyNow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuyNow.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnBuyNow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuyNow.FillColor = Color.FromArgb(95, 77, 214);
            btnBuyNow.FillColor2 = Color.FromArgb(95, 77, 214);
            btnBuyNow.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuyNow.ForeColor = Color.White;
            btnBuyNow.Location = new Point(176, 401);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnBuyNow.Size = new Size(157, 36);
            btnBuyNow.TabIndex = 35;
            btnBuyNow.Text = "Buy Now";
            btnBuyNow.Click += btnBuyNow_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Animated = true;
            btnAddToCart.BorderColor = Color.FromArgb(239, 240, 243);
            btnAddToCart.BorderRadius = 4;
            btnAddToCart.BorderThickness = 2;
            btnAddToCart.CustomizableEdges = customizableEdges13;
            btnAddToCart.DisabledState.BorderColor = Color.DarkGray;
            btnAddToCart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddToCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddToCart.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAddToCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddToCart.FillColor = Color.White;
            btnAddToCart.FillColor2 = Color.White;
            btnAddToCart.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(13, 401);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAddToCart.Size = new Size(157, 36);
            btnAddToCart.TabIndex = 34;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblRatingAvg
            // 
            lblRatingAvg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRatingAvg.BackColor = Color.White;
            lblRatingAvg.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            lblRatingAvg.ForeColor = Color.DarkGray;
            lblRatingAvg.Location = new Point(161, 363);
            lblRatingAvg.Name = "lblRatingAvg";
            lblRatingAvg.RightToLeft = RightToLeft.Yes;
            lblRatingAvg.Size = new Size(46, 37);
            lblRatingAvg.TabIndex = 20;
            lblRatingAvg.Text = "0.0";
            lblRatingAvg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalRating
            // 
            lblTotalRating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalRating.BackColor = Color.White;
            lblTotalRating.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            lblTotalRating.ForeColor = Color.DarkGray;
            lblTotalRating.Location = new Point(273, 361);
            lblTotalRating.Name = "lblTotalRating";
            lblTotalRating.RightToLeft = RightToLeft.Yes;
            lblTotalRating.Size = new Size(57, 37);
            lblTotalRating.TabIndex = 19;
            lblTotalRating.Text = "(-)";
            lblTotalRating.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uctrlProductSamary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrlProductSamary";
            Size = new Size(351, 447);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Label lblProductName;
        private Label lblProductCategory;
        private Label lblPrice;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTotalRating;
        private Label lblRatingAvg;
        public Guna.UI2.WinForms.Guna2GradientButton btnAddToCart;
        public Guna.UI2.WinForms.Guna2GradientButton btnBuyNow;
    }
}
