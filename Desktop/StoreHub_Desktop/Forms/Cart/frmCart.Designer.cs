namespace StoreHub_Desktop.Forms.Cart
{
    partial class frmCart
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
            lblBtnExit = new Label();
            btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lblProductName = new Label();
            lblCartItemsCount = new Label();
            flpReviews = new FlowLayoutPanel();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            lblTotalPrice = new Label();
            SuspendLayout();
            // 
            // lblBtnExit
            // 
            lblBtnExit.AutoSize = true;
            lblBtnExit.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnExit.ForeColor = Color.FromArgb(64, 64, 64);
            lblBtnExit.Location = new Point(588, 9);
            lblBtnExit.Name = "lblBtnExit";
            lblBtnExit.Size = new Size(37, 37);
            lblBtnExit.TabIndex = 1;
            lblBtnExit.Text = "×";
            lblBtnExit.Click += lblBtnExit_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Animated = true;
            btnCheckout.BorderRadius = 10;
            btnCheckout.CustomizableEdges = customizableEdges1;
            btnCheckout.DisabledState.BorderColor = Color.DarkGray;
            btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckout.Enabled = false;
            btnCheckout.FillColor = Color.FromArgb(95, 77, 214);
            btnCheckout.FillColor2 = Color.FromArgb(63, 41, 202);
            btnCheckout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(32, 806);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCheckout.Size = new Size(580, 51);
            btnCheckout.TabIndex = 33;
            btnCheckout.Text = "Checkout";
            btnCheckout.Click += guna2GradientButton1_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(32, 70);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(580, 17);
            guna2Separator1.TabIndex = 34;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(32, 16);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(137, 37);
            lblProductName.TabIndex = 35;
            lblProductName.Text = "Your Cart";
            // 
            // lblCartItemsCount
            // 
            lblCartItemsCount.AutoSize = true;
            lblCartItemsCount.BackColor = Color.Transparent;
            lblCartItemsCount.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartItemsCount.ForeColor = Color.Black;
            lblCartItemsCount.Location = new Point(162, 16);
            lblCartItemsCount.Name = "lblCartItemsCount";
            lblCartItemsCount.Size = new Size(53, 37);
            lblCartItemsCount.TabIndex = 36;
            lblCartItemsCount.Text = "(0)";
            // 
            // flpReviews
            // 
            flpReviews.AutoScroll = true;
            flpReviews.Location = new Point(26, 106);
            flpReviews.Name = "flpReviews";
            flpReviews.Size = new Size(594, 586);
            flpReviews.TabIndex = 37;
            // 
            // guna2Separator2
            // 
            guna2Separator2.Location = new Point(32, 698);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(580, 17);
            guna2Separator2.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 728);
            label1.Name = "label1";
            label1.Size = new Size(81, 37);
            label1.TabIndex = 39;
            label1.Text = "Total";
            // 
            // guna2GradientButton2
            // 
            guna2GradientButton2.Animated = true;
            guna2GradientButton2.BorderRadius = 10;
            guna2GradientButton2.CustomizableEdges = customizableEdges3;
            guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton2.FillColor = Color.Transparent;
            guna2GradientButton2.FillColor2 = Color.Transparent;
            guna2GradientButton2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientButton2.ForeColor = Color.FromArgb(95, 77, 214);
            guna2GradientButton2.Location = new Point(32, 873);
            guna2GradientButton2.Name = "guna2GradientButton2";
            guna2GradientButton2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientButton2.Size = new Size(580, 51);
            guna2GradientButton2.TabIndex = 40;
            guna2GradientButton2.Text = "Continue Shopping";
            guna2GradientButton2.Click += guna2GradientButton2_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.None;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.FromArgb(95, 77, 214);
            lblTotalPrice.Location = new Point(119, 728);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(502, 37);
            lblTotalPrice.TabIndex = 42;
            lblTotalPrice.Text = "$0.0";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(638, 947);
            Controls.Add(lblTotalPrice);
            Controls.Add(guna2GradientButton2);
            Controls.Add(label1);
            Controls.Add(guna2Separator2);
            Controls.Add(flpReviews);
            Controls.Add(lblCartItemsCount);
            Controls.Add(lblProductName);
            Controls.Add(guna2Separator1);
            Controls.Add(btnCheckout);
            Controls.Add(lblBtnExit);
            Name = "frmCart";
            Text = "frmCart";
            Load += frmCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBtnExit;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label lblProductName;
        private Label lblCartItemsCount;
        private FlowLayoutPanel flpReviews;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Label lblTotalPrice;
    }
}