namespace StoreHub_Desktop.Forms.Admin
{
    partial class frmAddEditUser
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
            uctrlUserDetailsRowsWithEdit1 = new StoreHub_Desktop.User_Controls.Menu.MyProfile.uctrlUserDetailsRowsWithEdit();
            lblCaption = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // uctrlUserDetailsRowsWithEdit1
            // 
            uctrlUserDetailsRowsWithEdit1.BackColor = Color.Transparent;
            uctrlUserDetailsRowsWithEdit1.Location = new Point(69, 90);
            uctrlUserDetailsRowsWithEdit1.Name = "uctrlUserDetailsRowsWithEdit1";
            uctrlUserDetailsRowsWithEdit1.SetForAddUser = false;
            uctrlUserDetailsRowsWithEdit1.Size = new Size(1059, 606);
            uctrlUserDetailsRowsWithEdit1.TabIndex = 0;
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.BackColor = Color.Transparent;
            lblCaption.Cursor = Cursors.Hand;
            lblCaption.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaption.ForeColor = Color.Black;
            lblCaption.Location = new Point(12, 9);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(159, 45);
            lblCaption.TabIndex = 48;
            lblCaption.Text = "Add User";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(12, 65);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1195, 17);
            guna2Separator1.TabIndex = 49;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 719);
            Controls.Add(guna2Separator1);
            Controls.Add(lblCaption);
            Controls.Add(uctrlUserDetailsRowsWithEdit1);
            Name = "frmAddEditUser";
            Text = "frmAddEditUser";
            Load += frmAddEditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Menu.MyProfile.uctrlUserDetailsRowsWithEdit uctrlUserDetailsRowsWithEdit1;
        private Label lblCaption;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}