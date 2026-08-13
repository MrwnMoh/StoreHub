namespace StoreHub_Desktop.User_Controls.Products
{
    partial class uctrlProductInCart
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            nmcQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblPrice = new Label();
            lblProductName = new Label();
            pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcQuantity).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel4
            // 
            guna2Panel4.Controls.Add(guna2Separator1);
            guna2Panel4.Controls.Add(label1);
            guna2Panel4.Controls.Add(nmcQuantity);
            guna2Panel4.Controls.Add(btnDelete);
            guna2Panel4.Controls.Add(flowLayoutPanel1);
            guna2Panel4.Controls.Add(lblProductName);
            guna2Panel4.Controls.Add(pbProductImage);
            guna2Panel4.CustomizableEdges = customizableEdges6;
            guna2Panel4.Location = new Point(0, 0);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2Panel4.Size = new Size(570, 142);
            guna2Panel4.TabIndex = 3;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(13, 126);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(541, 17);
            guna2Separator1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 55, 68);
            label1.Location = new Point(124, 94);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 32;
            label1.Text = "Quantity:";
            // 
            // nmcQuantity
            // 
            nmcQuantity.BackColor = Color.Transparent;
            nmcQuantity.BorderRadius = 5;
            nmcQuantity.CustomizableEdges = customizableEdges1;
            nmcQuantity.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            nmcQuantity.Location = new Point(211, 86);
            nmcQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmcQuantity.Name = "nmcQuantity";
            nmcQuantity.ShadowDecoration.CustomizableEdges = customizableEdges2;
            nmcQuantity.Size = new Size(67, 36);
            nmcQuantity.TabIndex = 31;
            nmcQuantity.UpDownButtonFillColor = Color.FromArgb(95, 77, 214);
            nmcQuantity.UpDownButtonForeColor = Color.FromArgb(150, 0, 0, 0);
            nmcQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmcQuantity.ValueChanged += nmcQuantity_ValueChanged;
            // 
            // btnDelete
            // 
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageSize = new Size(30, 30);
            btnDelete.Location = new Point(504, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 30;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblPrice);
            flowLayoutPanel1.Location = new Point(124, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(321, 33);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(3, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 21);
            lblPrice.TabIndex = 23;
            lblPrice.Text = "000.0";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(46, 55, 68);
            lblProductName.Location = new Point(124, 16);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(120, 21);
            lblProductName.TabIndex = 22;
            lblProductName.Text = "Product Name";
            // 
            // pbProductImage
            // 
            pbProductImage.BorderRadius = 15;
            pbProductImage.CustomizableEdges = customizableEdges4;
            pbProductImage.Image = Properties.Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
            pbProductImage.ImageRotate = 0F;
            pbProductImage.Location = new Point(13, 16);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pbProductImage.Size = new Size(90, 90);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 2;
            pbProductImage.TabStop = false;
            // 
            // uctrlProductInCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel4);
            Name = "uctrlProductInCart";
            Size = new Size(570, 142);
            guna2Panel4.ResumeLayout(false);
            guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmcQuantity).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Label lblProductName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblPrice;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmcQuantity;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
