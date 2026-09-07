namespace StoreHub_Desktop.Forms.Seller
{
    partial class frmChangeStoreOrAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            lblShopName = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            fpblStores = new FlowLayoutPanel();
            btnCreateNewStore = new Guna.UI2.WinForms.Guna2GradientButton();
            lblDescription = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Aug_28__2026__10_41_36_PM;
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.BackColor = Color.Transparent;
            lblShopName.Cursor = Cursors.Hand;
            lblShopName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopName.ForeColor = Color.Black;
            lblShopName.Location = new Point(89, 140);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(308, 37);
            lblShopName.TabIndex = 60;
            lblShopName.Text = "Change or create store";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(11, 201);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(462, 17);
            guna2Separator1.TabIndex = 61;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(fpblStores);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(11, 224);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(462, 272);
            guna2Panel1.TabIndex = 62;
            // 
            // fpblStores
            // 
            fpblStores.AutoScroll = true;
            fpblStores.BackColor = Color.White;
            fpblStores.Location = new Point(5, 5);
            fpblStores.Name = "fpblStores";
            fpblStores.Size = new Size(443, 255);
            fpblStores.TabIndex = 0;
            // 
            // btnCreateNewStore
            // 
            btnCreateNewStore.Animated = true;
            btnCreateNewStore.BorderRadius = 10;
            btnCreateNewStore.CustomizableEdges = customizableEdges3;
            btnCreateNewStore.DisabledState.BorderColor = Color.DarkGray;
            btnCreateNewStore.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateNewStore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateNewStore.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCreateNewStore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateNewStore.FillColor = Color.FromArgb(95, 77, 214);
            btnCreateNewStore.FillColor2 = Color.FromArgb(63, 41, 202);
            btnCreateNewStore.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateNewStore.ForeColor = Color.White;
            btnCreateNewStore.Location = new Point(27, 506);
            btnCreateNewStore.Name = "btnCreateNewStore";
            btnCreateNewStore.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCreateNewStore.Size = new Size(427, 48);
            btnCreateNewStore.TabIndex = 63;
            btnCreateNewStore.Text = "Create new store";
            btnCreateNewStore.Click += btnCreateNewStore_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Cursor = Cursors.Hand;
            lblDescription.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DarkGray;
            lblDescription.Location = new Point(107, 177);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(273, 21);
            lblDescription.TabIndex = 64;
            lblDescription.Text = "Your others stores will appear here";
            // 
            // btnBack
            // 
            btnBack.Animated = true;
            btnBack.BorderColor = Color.FromArgb(95, 77, 214);
            btnBack.BorderRadius = 10;
            btnBack.BorderThickness = 2;
            btnBack.CustomizableEdges = customizableEdges5;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.FillColor2 = Color.White;
            btnBack.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(95, 77, 214);
            btnBack.Location = new Point(27, 560);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBack.Size = new Size(427, 48);
            btnBack.TabIndex = 65;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // frmChangeStoreOrAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(486, 616);
            Controls.Add(btnBack);
            Controls.Add(btnCreateNewStore);
            Controls.Add(lblDescription);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Separator1);
            Controls.Add(lblShopName);
            Controls.Add(pictureBox1);
            Name = "frmChangeStoreOrAdd";
            Text = "frmChangeStoreOrAdd";
            Load += frmChangeStoreOrAdd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblShopName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FlowLayoutPanel fpblStores;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateNewStore;
        private Label lblDescription;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
    }
}