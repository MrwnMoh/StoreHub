namespace StoreHub_Desktop.User_Controls.Order
{
    partial class uctrlOrderStatus
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
            btnStatus = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // btnStatus
            // 
            btnStatus.Animated = true;
            btnStatus.BorderColor = Color.FromArgb(252, 131, 19);
            btnStatus.BorderRadius = 8;
            btnStatus.BorderThickness = 1;
            btnStatus.CustomizableEdges = customizableEdges1;
            btnStatus.DisabledState.BorderColor = Color.DarkGray;
            btnStatus.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStatus.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStatus.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnStatus.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStatus.FillColor = Color.FromArgb(254, 244, 225);
            btnStatus.FillColor2 = Color.FromArgb(254, 244, 225);
            btnStatus.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.FromArgb(252, 131, 19);
            btnStatus.Image = Properties.Resources.ChatGPT_Image_Aug_23__2026__07_09_24_PM__3_;
            btnStatus.ImageSize = new Size(25, 25);
            btnStatus.Location = new Point(0, 0);
            btnStatus.Name = "btnStatus";
            btnStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnStatus.Size = new Size(132, 40);
            btnStatus.TabIndex = 56;
            btnStatus.Text = "View Details";
            // 
            // uctrlOrderStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnStatus);
            Name = "uctrlOrderStatus";
            Size = new Size(132, 40);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblOrderItems;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatus;
    }
}
