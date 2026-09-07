namespace StoreHub_Desktop.User_Controls.Admin.Users
{
    partial class UctrlUserRow
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ucIsMale = new uctrlIsActive();
            btnNotActive = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            ucIsSeller = new uctrlIsActive();
            ucIsActive = new uctrlIsActive();
            ucIsAdmin = new uctrlIsActive();
            lblPhone = new Label();
            lblEmail = new Label();
            lblUserFullName = new Label();
            pbUserPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserPic).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(ucIsMale);
            guna2Panel1.Controls.Add(btnNotActive);
            guna2Panel1.Controls.Add(btnEdit);
            guna2Panel1.Controls.Add(ucIsSeller);
            guna2Panel1.Controls.Add(ucIsActive);
            guna2Panel1.Controls.Add(ucIsAdmin);
            guna2Panel1.Controls.Add(lblPhone);
            guna2Panel1.Controls.Add(lblEmail);
            guna2Panel1.Controls.Add(lblUserFullName);
            guna2Panel1.Controls.Add(pbUserPic);
            guna2Panel1.CustomizableEdges = customizableEdges6;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2Panel1.Size = new Size(1600, 94);
            guna2Panel1.TabIndex = 0;
            // 
            // ucIsMale
            // 
            ucIsMale.BackColor = Color.Transparent;
            ucIsMale.Location = new Point(878, 27);
            ucIsMale.Name = "ucIsMale";
            ucIsMale.Size = new Size(76, 34);
            ucIsMale.Status = true;
            ucIsMale.TabIndex = 55;
            // 
            // btnNotActive
            // 
            btnNotActive.Animated = true;
            btnNotActive.BorderColor = Color.Red;
            btnNotActive.BorderRadius = 5;
            btnNotActive.BorderThickness = 1;
            btnNotActive.CustomizableEdges = customizableEdges1;
            btnNotActive.DisabledState.BorderColor = Color.DarkGray;
            btnNotActive.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNotActive.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNotActive.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnNotActive.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNotActive.FillColor = Color.White;
            btnNotActive.FillColor2 = Color.White;
            btnNotActive.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotActive.ForeColor = Color.Red;
            btnNotActive.Location = new Point(1466, 27);
            btnNotActive.Name = "btnNotActive";
            btnNotActive.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNotActive.Size = new Size(122, 34);
            btnNotActive.TabIndex = 54;
            btnNotActive.Text = "Not Active";
            btnNotActive.Click += btnNotActive_Click;
            // 
            // btnEdit
            // 
            btnEdit.Animated = true;
            btnEdit.BorderColor = Color.FromArgb(95, 77, 214);
            btnEdit.BorderRadius = 5;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges3;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.White;
            btnEdit.FillColor2 = Color.White;
            btnEdit.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(95, 77, 214);
            btnEdit.Image = Properties.Resources.Edit;
            btnEdit.ImageSize = new Size(30, 30);
            btnEdit.Location = new Point(1338, 27);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(122, 34);
            btnEdit.TabIndex = 53;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // ucIsSeller
            // 
            ucIsSeller.BackColor = Color.Transparent;
            ucIsSeller.Location = new Point(1232, 27);
            ucIsSeller.Name = "ucIsSeller";
            ucIsSeller.Size = new Size(76, 34);
            ucIsSeller.Status = true;
            ucIsSeller.TabIndex = 52;
            // 
            // ucIsActive
            // 
            ucIsActive.BackColor = Color.Transparent;
            ucIsActive.Location = new Point(1114, 27);
            ucIsActive.Name = "ucIsActive";
            ucIsActive.Size = new Size(76, 34);
            ucIsActive.Status = true;
            ucIsActive.TabIndex = 51;
            // 
            // ucIsAdmin
            // 
            ucIsAdmin.BackColor = Color.Transparent;
            ucIsAdmin.Location = new Point(996, 27);
            ucIsAdmin.Name = "ucIsAdmin";
            ucIsAdmin.Size = new Size(76, 34);
            ucIsAdmin.Status = true;
            ucIsAdmin.TabIndex = 50;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Cursor = Cursors.Hand;
            lblPhone.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(611, 34);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 21);
            lblPhone.TabIndex = 49;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Cursor = Cursors.Hand;
            lblEmail.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(347, 34);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 48;
            lblEmail.Text = "Email";
            // 
            // lblUserFullName
            // 
            lblUserFullName.AutoSize = true;
            lblUserFullName.BackColor = Color.Transparent;
            lblUserFullName.Cursor = Cursors.Hand;
            lblUserFullName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserFullName.ForeColor = Color.Black;
            lblUserFullName.Location = new Point(84, 34);
            lblUserFullName.Name = "lblUserFullName";
            lblUserFullName.Size = new Size(84, 21);
            lblUserFullName.TabIndex = 47;
            lblUserFullName.Text = "FullName";
            // 
            // pbUserPic
            // 
            pbUserPic.Image = Properties.Resources.Male;
            pbUserPic.ImageRotate = 0F;
            pbUserPic.Location = new Point(14, 15);
            pbUserPic.Name = "pbUserPic";
            pbUserPic.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pbUserPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbUserPic.Size = new Size(64, 64);
            pbUserPic.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserPic.TabIndex = 0;
            pbUserPic.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // UctrlUserRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "UctrlUserRow";
            Size = new Size(1600, 94);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserPic;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblUserFullName;
        private uctrlIsActive ucIsSeller;
        private uctrlIsActive ucIsActive;
        private uctrlIsActive ucIsAdmin;
        private Guna.UI2.WinForms.Guna2GradientButton btnNotActive;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private uctrlIsActive ucIsMale;
    }
}
