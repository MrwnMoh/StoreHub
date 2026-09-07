namespace StoreHub_Desktop.User_Controls.Seller
{
    partial class uctrl_NoStore
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            label2 = new Label();
            btnCreateStore = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBtnBack = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.FromArgb(230, 220, 250);
            guna2Panel1.BorderRadius = 16;
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(btnCreateStore);
            guna2Panel1.Controls.Add(lblBtnBack);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.FromArgb(230, 220, 250);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1039, 497);
            guna2Panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(376, 409);
            label4.Name = "label4";
            label4.Size = new Size(281, 21);
            label4.TabIndex = 44;
            label4.Text = "orders, and reviews all in one place.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(299, 388);
            label2.Name = "label2";
            label2.Size = new Size(435, 21);
            label2.TabIndex = 42;
            label2.Text = "Once you create a shop, you can manage your products,";
            // 
            // btnCreateStore
            // 
            btnCreateStore.Animated = true;
            btnCreateStore.BorderRadius = 10;
            btnCreateStore.CustomizableEdges = customizableEdges1;
            btnCreateStore.DisabledState.BorderColor = Color.DarkGray;
            btnCreateStore.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateStore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateStore.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCreateStore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateStore.FillColor = Color.FromArgb(95, 77, 214);
            btnCreateStore.FillColor2 = Color.FromArgb(63, 41, 202);
            btnCreateStore.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnCreateStore.ForeColor = Color.White;
            btnCreateStore.Location = new Point(376, 328);
            btnCreateStore.Name = "btnCreateStore";
            btnCreateStore.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCreateStore.Size = new Size(277, 48);
            btnCreateStore.TabIndex = 41;
            btnCreateStore.Text = "Creaet New Store";
            btnCreateStore.Click += btnCreateStore_Click;
            // 
            // lblBtnBack
            // 
            lblBtnBack.AutoSize = true;
            lblBtnBack.BackColor = Color.Transparent;
            lblBtnBack.Cursor = Cursors.Hand;
            lblBtnBack.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnBack.ForeColor = Color.Black;
            lblBtnBack.Location = new Point(313, 248);
            lblBtnBack.Name = "lblBtnBack";
            lblBtnBack.Size = new Size(411, 45);
            lblBtnBack.TabIndex = 40;
            lblBtnBack.Text = "You Don't have a store yet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(324, 297);
            label1.Name = "label1";
            label1.Size = new Size(386, 21);
            label1.TabIndex = 39;
            label1.Text = "Create your first store to start selling on StoreHub";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Aug_28__2026__10_41_36_PM;
            pictureBox1.Location = new Point(401, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uctrl_NoStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrl_NoStore";
            Size = new Size(1042, 503);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox pictureBox1;
        private Label lblBtnBack;
        private Label label1;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateStore;
    }
}
