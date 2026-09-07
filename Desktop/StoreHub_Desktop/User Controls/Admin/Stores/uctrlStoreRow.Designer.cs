namespace StoreHub_Desktop.User_Controls.Admin.Stores
{
    partial class uctrlStoreRow
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblStoreName = new Label();
            lblStoreOwnerFullName = new Label();
            lblStoreId = new Label();
            lblORdersCount = new Label();
            lblProductsCount = new Label();
            lblREviewnu = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(lblREviewnu);
            guna2Panel1.Controls.Add(lblProductsCount);
            guna2Panel1.Controls.Add(lblORdersCount);
            guna2Panel1.Controls.Add(lblStoreName);
            guna2Panel1.Controls.Add(lblStoreOwnerFullName);
            guna2Panel1.Controls.Add(lblStoreId);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1520, 94);
            guna2Panel1.TabIndex = 1;
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.BackColor = Color.Transparent;
            lblStoreName.Cursor = Cursors.Hand;
            lblStoreName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreName.ForeColor = Color.Gray;
            lblStoreName.Location = new Point(544, 34);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(95, 21);
            lblStoreName.TabIndex = 49;
            lblStoreName.Text = "StoreName";
            // 
            // lblStoreOwnerFullName
            // 
            lblStoreOwnerFullName.AutoSize = true;
            lblStoreOwnerFullName.BackColor = Color.Transparent;
            lblStoreOwnerFullName.Cursor = Cursors.Hand;
            lblStoreOwnerFullName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreOwnerFullName.ForeColor = Color.Black;
            lblStoreOwnerFullName.Location = new Point(174, 34);
            lblStoreOwnerFullName.Name = "lblStoreOwnerFullName";
            lblStoreOwnerFullName.Size = new Size(173, 21);
            lblStoreOwnerFullName.TabIndex = 48;
            lblStoreOwnerFullName.Text = "StoreOwnerFullName";
            // 
            // lblStoreId
            // 
            lblStoreId.AutoSize = true;
            lblStoreId.BackColor = Color.Transparent;
            lblStoreId.Cursor = Cursors.Hand;
            lblStoreId.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreId.ForeColor = Color.FromArgb(95, 77, 214);
            lblStoreId.Location = new Point(14, 34);
            lblStoreId.Name = "lblStoreId";
            lblStoreId.Size = new Size(64, 21);
            lblStoreId.TabIndex = 47;
            lblStoreId.Text = "StoreId";
            // 
            // lblORdersCount
            // 
            lblORdersCount.AutoSize = true;
            lblORdersCount.BackColor = Color.Transparent;
            lblORdersCount.Cursor = Cursors.Hand;
            lblORdersCount.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblORdersCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblORdersCount.Location = new Point(867, 34);
            lblORdersCount.Name = "lblORdersCount";
            lblORdersCount.Size = new Size(106, 21);
            lblORdersCount.TabIndex = 50;
            lblORdersCount.Text = "OrdersCount";
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.BackColor = Color.Transparent;
            lblProductsCount.Cursor = Cursors.Hand;
            lblProductsCount.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductsCount.Location = new Point(1061, 34);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(123, 21);
            lblProductsCount.TabIndex = 51;
            lblProductsCount.Text = "ProductsCount";
            // 
            // lblREviewnu
            // 
            lblREviewnu.BackColor = Color.Transparent;
            lblREviewnu.Cursor = Cursors.Hand;
            lblREviewnu.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblREviewnu.ForeColor = Color.FromArgb(95, 77, 214);
            lblREviewnu.Location = new Point(1240, 34);
            lblREviewnu.Name = "lblREviewnu";
            lblREviewnu.Size = new Size(263, 21);
            lblREviewnu.TabIndex = 52;
            lblREviewnu.Text = "Revenu";
            lblREviewnu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uctrlStoreRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrlStoreRow";
            Size = new Size(1523, 94);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblStoreName;
        private Label lblStoreOwnerFullName;
        private Label lblStoreId;
        private Label lblORdersCount;
        private Label lblREviewnu;
        private Label lblProductsCount;
    }
}
