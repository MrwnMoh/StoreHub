namespace StoreHub_Desktop.Forms
{
    partial class frmMainApp
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

        #region Windows Form Designer generated code

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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            homeProducts1 = new StoreHub_Desktop.User_Controls.Products.HomeProducts();
            bigBanner1 = new StoreHub_Desktop.User_Controls.BigBanner();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            btnCart = new Guna.UI2.WinForms.Guna2GradientButton();
            lblCartItemsCount = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.AutoScroll = true;
            guna2Panel1.BorderColor = Color.FromArgb(239, 240, 243);
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(homeProducts1);
            guna2Panel1.Controls.Add(bigBanner1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(0, 105);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1675, 875);
            guna2Panel1.TabIndex = 0;
            // 
            // homeProducts1
            // 
            homeProducts1.BackColor = Color.Transparent;
            homeProducts1.Location = new Point(85, 556);
            homeProducts1.Name = "homeProducts1";
            homeProducts1.Size = new Size(1512, 1580);
            homeProducts1.TabIndex = 1;
            // 
            // bigBanner1
            // 
            bigBanner1.BackColor = Color.Transparent;
            bigBanner1.BannarImage = User_Controls.BigBanner.EBannars.Electornics;
            bigBanner1.Location = new Point(85, 31);
            bigBanner1.Name = "bigBanner1";
            bigBanner1.SetAutomaticChanges = true;
            bigBanner1.Size = new Size(1515, 495);
            bigBanner1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_08_10_184706;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Nirmala UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(24, 32, 49);
            label11.Location = new Point(113, 27);
            label11.Name = "label11";
            label11.Size = new Size(177, 47);
            label11.TabIndex = 16;
            label11.Text = "StoreHub";
            // 
            // btnCart
            // 
            btnCart.Animated = true;
            btnCart.BorderColor = Color.FromArgb(239, 240, 243);
            btnCart.BorderRadius = 10;
            btnCart.CustomizableEdges = customizableEdges3;
            btnCart.DisabledState.BorderColor = Color.DarkGray;
            btnCart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCart.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCart.FillColor = Color.Transparent;
            btnCart.FillColor2 = Color.Transparent;
            btnCart.Font = new Font("Nunito", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCart.ForeColor = Color.Black;
            btnCart.Image = Properties.Resources.shopping_cart__1_;
            btnCart.ImageSize = new Size(25, 25);
            btnCart.Location = new Point(1055, 27);
            btnCart.Name = "btnCart";
            btnCart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCart.Size = new Size(87, 35);
            btnCart.TabIndex = 34;
            btnCart.Text = "Cart";
            btnCart.Click += btnCart_Click;
            // 
            // lblCartItemsCount
            // 
            lblCartItemsCount.AutoSize = true;
            lblCartItemsCount.BackColor = Color.Transparent;
            lblCartItemsCount.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartItemsCount.ForeColor = Color.FromArgb(63, 41, 202);
            lblCartItemsCount.Location = new Point(1148, 12);
            lblCartItemsCount.Name = "lblCartItemsCount";
            lblCartItemsCount.Size = new Size(18, 20);
            lblCartItemsCount.TabIndex = 35;
            lblCartItemsCount.Text = "0";
            // 
            // frmMainApp
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1675, 980);
            Controls.Add(lblCartItemsCount);
            Controls.Add(btnCart);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(guna2Panel1);
            Name = "frmMainApp";
            Text = "MainApp";
            Load += frmMainApp_Load;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private User_Controls.BigBanner bigBanner1;
        private User_Controls.Products.HomeProducts homeProducts1;
        private PictureBox pictureBox1;
        private Label label11;
        private Guna.UI2.WinForms.Guna2GradientButton btnCart;
        private Label lblCartItemsCount;
    }
}