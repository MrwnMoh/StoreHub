namespace StoreHub_Desktop.User_Controls.Products.Reviews
{
    partial class uctrl_MyReviewView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblReviewText = new Label();
            lblRatingAvg = new Label();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            btnViewProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            lblProductName = new Label();
            lblReviewDate = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(lblReviewText);
            guna2Panel1.Controls.Add(lblRatingAvg);
            guna2Panel1.Controls.Add(guna2RatingStar1);
            guna2Panel1.Controls.Add(pbProductImage);
            guna2Panel1.Controls.Add(btnViewProduct);
            guna2Panel1.Controls.Add(lblProductName);
            guna2Panel1.Controls.Add(lblReviewDate);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(1500, 195);
            guna2Panel1.TabIndex = 1;
            // 
            // lblReviewText
            // 
            lblReviewText.BackColor = Color.White;
            lblReviewText.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviewText.ForeColor = Color.Black;
            lblReviewText.Location = new Point(327, 115);
            lblReviewText.Name = "lblReviewText";
            lblReviewText.Size = new Size(868, 60);
            lblReviewText.TabIndex = 58;
            lblReviewText.Text = "Product Name";
            // 
            // lblRatingAvg
            // 
            lblRatingAvg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRatingAvg.BackColor = Color.White;
            lblRatingAvg.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            lblRatingAvg.ForeColor = Color.DarkGray;
            lblRatingAvg.Location = new Point(474, 57);
            lblRatingAvg.Name = "lblRatingAvg";
            lblRatingAvg.RightToLeft = RightToLeft.Yes;
            lblRatingAvg.Size = new Size(46, 37);
            lblRatingAvg.TabIndex = 57;
            lblRatingAvg.Text = "0.0";
            lblRatingAvg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(327, 61);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.RatingColor = Color.FromArgb(250, 192, 96);
            guna2RatingStar1.ReadOnly = true;
            guna2RatingStar1.Size = new Size(141, 28);
            guna2RatingStar1.TabIndex = 56;
            // 
            // pbProductImage
            // 
            pbProductImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbProductImage.BorderRadius = 15;
            pbProductImage.CustomizableEdges = customizableEdges7;
            pbProductImage.Image = Properties.Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
            pbProductImage.ImageRotate = 0F;
            pbProductImage.Location = new Point(21, 21);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pbProductImage.Size = new Size(300, 154);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 55;
            pbProductImage.TabStop = false;
            // 
            // btnViewProduct
            // 
            btnViewProduct.Animated = true;
            btnViewProduct.BorderColor = Color.FromArgb(95, 77, 214);
            btnViewProduct.BorderRadius = 8;
            btnViewProduct.BorderThickness = 1;
            btnViewProduct.CustomizableEdges = customizableEdges9;
            btnViewProduct.DisabledState.BorderColor = Color.DarkGray;
            btnViewProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewProduct.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnViewProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewProduct.FillColor = Color.Transparent;
            btnViewProduct.FillColor2 = Color.Transparent;
            btnViewProduct.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewProduct.ForeColor = Color.FromArgb(95, 77, 214);
            btnViewProduct.Location = new Point(1250, 112);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnViewProduct.Size = new Size(223, 63);
            btnViewProduct.TabIndex = 54;
            btnViewProduct.Text = "View Product";
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.White;
            lblProductName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(327, 21);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(202, 37);
            lblProductName.TabIndex = 42;
            lblProductName.Text = "Product Name";
            // 
            // lblReviewDate
            // 
            lblReviewDate.AutoSize = true;
            lblReviewDate.BackColor = Color.White;
            lblReviewDate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviewDate.ForeColor = Color.DarkGray;
            lblReviewDate.Location = new Point(327, 94);
            lblReviewDate.Name = "lblReviewDate";
            lblReviewDate.Size = new Size(90, 21);
            lblReviewDate.TabIndex = 41;
            lblReviewDate.Text = "00 00 0000";
            // 
            // uctrl_MyReviewView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrl_MyReviewView";
            Size = new Size(1500, 198);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewProduct;
        private Label lblProductName;
        private Label lblReviewDate;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Label lblRatingAvg;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Label lblReviewText;
    }
}
