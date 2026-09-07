namespace StoreHub_Desktop.User_Controls.Products.Category
{
    partial class uctrlProductCategoryRow
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
            pnl = new Guna.UI2.WinForms.Guna2Panel();
            lblCategoryName = new Label();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.BorderRadius = 10;
            pnl.Controls.Add(lblCategoryName);
            pnl.Cursor = Cursors.Hand;
            pnl.CustomizableEdges = customizableEdges1;
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnl.Size = new Size(300, 58);
            pnl.TabIndex = 0;
            // 
            // lblCategoryName
            // 
            lblCategoryName.BackColor = Color.Transparent;
            lblCategoryName.Cursor = Cursors.Hand;
            lblCategoryName.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.ForeColor = Color.FromArgb(46, 55, 68);
            lblCategoryName.Location = new Point(3, 9);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(297, 37);
            lblCategoryName.TabIndex = 40;
            lblCategoryName.Text = "All Categories";
            lblCategoryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uctrlProductCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnl);
            Name = "uctrlProductCategory";
            Size = new Size(300, 58);
            pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl;
        private Label lblCategoryName;
    }
}
