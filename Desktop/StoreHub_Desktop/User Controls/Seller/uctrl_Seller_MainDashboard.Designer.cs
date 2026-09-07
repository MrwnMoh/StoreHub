namespace StoreHub_Desktop.User_Controls.Seller
{
    partial class uctrl_Seller_MainDashboard
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
            lblBtnBack = new Label();
            label1 = new Label();
            lblProductName = new Label();
            pnlContaner = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // lblBtnBack
            // 
            lblBtnBack.AutoSize = true;
            lblBtnBack.BackColor = Color.Transparent;
            lblBtnBack.Cursor = Cursors.Hand;
            lblBtnBack.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnBack.ForeColor = Color.Black;
            lblBtnBack.Location = new Point(16, 3);
            lblBtnBack.Name = "lblBtnBack";
            lblBtnBack.Size = new Size(93, 37);
            lblBtnBack.TabIndex = 41;
            lblBtnBack.Text = "‹ Back";
            lblBtnBack.Click += OnCLickBack;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(22, 86);
            label1.Name = "label1";
            label1.Size = new Size(317, 17);
            label1.TabIndex = 40;
            label1.Text = "Manage your shop, products, orders, and reviews.";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(46, 55, 68);
            lblProductName.Location = new Point(16, 49);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(236, 37);
            lblProductName.TabIndex = 39;
            lblProductName.Text = "Seller Dashboard";
            // 
            // pnlContaner
            // 
            pnlContaner.AutoSize = true;
            pnlContaner.CustomizableEdges = customizableEdges1;
            pnlContaner.Location = new Point(22, 111);
            pnlContaner.Name = "pnlContaner";
            pnlContaner.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlContaner.Size = new Size(1617, 524);
            pnlContaner.TabIndex = 43;
            // 
            // uctrl_Seller_MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(pnlContaner);
            Controls.Add(lblBtnBack);
            Controls.Add(label1);
            Controls.Add(lblProductName);
            Name = "uctrl_Seller_MainDashboard";
            Size = new Size(1642, 643);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBtnBack;
        private Label label1;
        private Label lblProductName;
        private Guna.UI2.WinForms.Guna2Panel pnlContaner;
    }
}
