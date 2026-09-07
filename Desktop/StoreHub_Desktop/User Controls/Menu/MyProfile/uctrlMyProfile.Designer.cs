namespace StoreHub_Desktop.User_Controls.Menu
{
    partial class uctrlMyProfile
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
            uctrlUserDetailsCard1 = new StoreHub_Desktop.User_Controls.Menu.MyProfile.uctrlUserDetailsCard();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            uctrlUserDetailsRowsWithEdit2 = new StoreHub_Desktop.User_Controls.Menu.MyProfile.uctrlUserDetailsRowsWithEdit();
            lblBtnBack = new Label();
            label1 = new Label();
            lblProductName = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uctrlUserDetailsCard1
            // 
            uctrlUserDetailsCard1.BackColor = Color.WhiteSmoke;
            uctrlUserDetailsCard1.Location = new Point(34, 198);
            uctrlUserDetailsCard1.Name = "uctrlUserDetailsCard1";
            uctrlUserDetailsCard1.Size = new Size(429, 493);
            uctrlUserDetailsCard1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(uctrlUserDetailsRowsWithEdit2);
            guna2Panel1.Controls.Add(uctrlUserDetailsCard1);
            guna2Panel1.Controls.Add(lblBtnBack);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblProductName);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.WhiteSmoke;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1600, 798);
            guna2Panel1.TabIndex = 2;
            // 
            // uctrlUserDetailsRowsWithEdit2
            // 
            uctrlUserDetailsRowsWithEdit2.BackColor = Color.Transparent;
            uctrlUserDetailsRowsWithEdit2.Location = new Point(513, 137);
            uctrlUserDetailsRowsWithEdit2.Name = "uctrlUserDetailsRowsWithEdit2";
            uctrlUserDetailsRowsWithEdit2.Size = new Size(1059, 606);
            uctrlUserDetailsRowsWithEdit2.TabIndex = 45;
            // 
            // lblBtnBack
            // 
            lblBtnBack.AutoSize = true;
            lblBtnBack.BackColor = Color.Transparent;
            lblBtnBack.Cursor = Cursors.Hand;
            lblBtnBack.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnBack.ForeColor = Color.Black;
            lblBtnBack.Location = new Point(16, 17);
            lblBtnBack.Name = "lblBtnBack";
            lblBtnBack.Size = new Size(93, 37);
            lblBtnBack.TabIndex = 44;
            lblBtnBack.Text = "‹ Back";
            lblBtnBack.Click += lblBtnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(23, 103);
            label1.Name = "label1";
            label1.Size = new Size(284, 17);
            label1.TabIndex = 43;
            label1.Text = "View and manage your account information.";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(46, 55, 68);
            lblProductName.Location = new Point(16, 68);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(151, 37);
            lblProductName.TabIndex = 42;
            lblProductName.Text = "My Profile";
            // 
            // uctrlMyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrlMyProfile";
            Size = new Size(1600, 798);
            Load += uctrlMyProfile_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MyProfile.uctrlUserDetailsCard uctrlUserDetailsCard1;
        private MyProfile.uctrlUserDetailsCard uctrlUserDetailsCard2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblBtnBack;
        private Label label1;
        private Label lblProductName;
        private MyProfile.uctrlUserDetailsRowsWithEdit uctrlUserDetailsRowsWithEdit1;
        private MyProfile.uctrlUserDetailsRowsWithEdit uctrlUserDetailsRowsWithEdit2;
    }
}
