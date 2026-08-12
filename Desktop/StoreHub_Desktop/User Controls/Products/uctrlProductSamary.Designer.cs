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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblProductName = new Label();
            lblProductCategory = new Label();
            lblPrice = new Label();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblRatingAvg = new Label();
            lblTotalRating = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2PictureBox1.BorderRadius = 15;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(33, 34);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(279, 183);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
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
            guna2RatingStar1.Location = new Point(14, 377);
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
            guna2Panel1.Controls.Add(lblRatingAvg);
            guna2Panel1.Controls.Add(lblTotalRating);
            guna2Panel1.Controls.Add(guna2RatingStar1);
            guna2Panel1.Controls.Add(lblPrice);
            guna2Panel1.Controls.Add(lblProductCategory);
            guna2Panel1.Controls.Add(lblProductName);
            guna2Panel1.Controls.Add(guna2PictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(351, 447);
            guna2Panel1.TabIndex = 1;
            // 
            // lblRatingAvg
            // 
            lblRatingAvg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRatingAvg.BackColor = Color.White;
            lblRatingAvg.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            lblRatingAvg.ForeColor = Color.DarkGray;
            lblRatingAvg.Location = new Point(161, 373);
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
            lblTotalRating.Location = new Point(273, 377);
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
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label lblProductName;
        private Label lblProductCategory;
        private Label lblPrice;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTotalRating;
        private Label lblRatingAvg;
    }
}
