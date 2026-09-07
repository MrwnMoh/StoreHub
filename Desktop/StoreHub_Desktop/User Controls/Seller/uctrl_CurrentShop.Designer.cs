namespace StoreHub_Desktop.User_Controls.Seller
{
    partial class uctrl_CurrentShop
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblDescription = new Label();
            lblShopName = new Label();
            lblBtnBack = new Label();
            pictureBox1 = new PictureBox();
            btnChangeShop = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Controls.Add(lblShopName);
            guna2Panel1.Controls.Add(lblBtnBack);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(btnChangeShop);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = Color.FromArgb(230, 220, 250);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(974, 204);
            guna2Panel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Cursor = Cursors.Hand;
            lblDescription.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DarkGray;
            lblDescription.Location = new Point(203, 86);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(537, 106);
            lblDescription.TabIndex = 60;
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.BackColor = Color.Transparent;
            lblShopName.Cursor = Cursors.Hand;
            lblShopName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopName.ForeColor = Color.Black;
            lblShopName.Location = new Point(203, 37);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(165, 37);
            lblShopName.TabIndex = 59;
            lblShopName.Text = "Shop Name";
            // 
            // lblBtnBack
            // 
            lblBtnBack.AutoSize = true;
            lblBtnBack.BackColor = Color.Transparent;
            lblBtnBack.Cursor = Cursors.Hand;
            lblBtnBack.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnBack.ForeColor = Color.FromArgb(95, 77, 214);
            lblBtnBack.Location = new Point(14, 9);
            lblBtnBack.Name = "lblBtnBack";
            lblBtnBack.Size = new Size(133, 25);
            lblBtnBack.TabIndex = 58;
            lblBtnBack.Text = "Current Store";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Aug_28__2026__10_41_36_PM;
            pictureBox1.Location = new Point(14, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnChangeShop
            // 
            btnChangeShop.Animated = true;
            btnChangeShop.BorderRadius = 10;
            btnChangeShop.CustomizableEdges = customizableEdges5;
            btnChangeShop.DisabledState.BorderColor = Color.DarkGray;
            btnChangeShop.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChangeShop.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChangeShop.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnChangeShop.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChangeShop.FillColor = Color.FromArgb(95, 77, 214);
            btnChangeShop.FillColor2 = Color.FromArgb(63, 41, 202);
            btnChangeShop.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeShop.ForeColor = Color.White;
            btnChangeShop.Location = new Point(778, 75);
            btnChangeShop.Name = "btnChangeShop";
            btnChangeShop.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnChangeShop.Size = new Size(173, 48);
            btnChangeShop.TabIndex = 42;
            btnChangeShop.Text = "Change Store";
            btnChangeShop.Click += btnChangeShop_Click;
            // 
            // uctrl_CurrentShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrl_CurrentShop";
            Size = new Size(974, 204);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangeShop;
        private PictureBox pictureBox1;
        private Label lblBtnBack;
        private Label lblDescription;
        private Label lblShopName;
    }
}
