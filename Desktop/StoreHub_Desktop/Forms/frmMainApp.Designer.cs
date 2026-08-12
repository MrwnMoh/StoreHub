namespace StoreHub_Desktop.Forms
{
    partial class frmMainApp
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            homeProducts1 = new StoreHub_Desktop.User_Controls.Products.HomeProducts();
            bigBanner1 = new StoreHub_Desktop.User_Controls.BigBanner();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.AutoScroll = true;
            guna2Panel1.BorderColor = Color.FromArgb(239, 240, 243);
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(homeProducts1);
            guna2Panel1.Controls.Add(bigBanner1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(0, 105);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1675, 875);
            guna2Panel1.TabIndex = 0;
            // 
            // homeProducts1
            // 
            homeProducts1.BackColor = Color.Transparent;
            homeProducts1.Location = new Point(85, 556);
            homeProducts1.Name = "homeProducts1";
            homeProducts1.Size = new Size(1512, 1580);
            homeProducts1.TabIndex = 1;
            // 
            // bigBanner1
            // 
            bigBanner1.BackColor = Color.Transparent;
            bigBanner1.BannarImage = User_Controls.BigBanner.EBannars.Books;
            bigBanner1.Location = new Point(85, 31);
            bigBanner1.Name = "bigBanner1";
            bigBanner1.SetAutomaticChanges = true;
            bigBanner1.Size = new Size(1515, 495);
            bigBanner1.TabIndex = 0;
            // 
            // frmMainApp
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1675, 980);
            Controls.Add(guna2Panel1);
            Name = "frmMainApp";
            Text = "MainApp";
            Load += frmMainApp_Load;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private User_Controls.BigBanner bigBanner1;
        private User_Controls.Products.HomeProducts homeProducts1;
    }
}