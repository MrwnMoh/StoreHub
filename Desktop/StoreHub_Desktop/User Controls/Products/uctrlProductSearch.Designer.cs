namespace StoreHub_Desktop.User_Controls.Products
{
    partial class uctrlProductSearch
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
            txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // txbSearch
            // 
            txbSearch.BorderColor = Color.FromArgb(95, 77, 214);
            txbSearch.BorderRadius = 10;
            txbSearch.CustomizableEdges = customizableEdges1;
            txbSearch.DefaultText = "";
            txbSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbSearch.Font = new Font("Nirmala Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbSearch.ForeColor = Color.FromArgb(95, 77, 214);
            txbSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbSearch.Location = new Point(4, 4);
            txbSearch.Margin = new Padding(4);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Search for a product...";
            txbSearch.SelectedText = "";
            txbSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txbSearch.Size = new Size(576, 59);
            txbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Animated = true;
            btnSearch.BorderColor = Color.White;
            btnSearch.BorderRadius = 10;
            btnSearch.BorderThickness = 1;
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(95, 77, 214);
            btnSearch.FillColor2 = Color.FromArgb(95, 77, 214);
            btnSearch.Font = new Font("VIP Hala Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(587, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(96, 59);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // uctrlProductSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Name = "uctrlProductSearch";
            Size = new Size(691, 70);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
    }
}
