namespace StoreHub_Desktop.Forms.Global
{
    partial class frmLogout
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            lblPrice = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            btnLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Separator2
            // 
            guna2Separator2.BackColor = Color.Transparent;
            guna2Separator2.Location = new Point(-3, 222);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(434, 17);
            guna2Separator2.TabIndex = 47;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(167, 115);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(102, 32);
            lblPrice.TabIndex = 46;
            lblPrice.Text = "Log out";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = Properties.Resources.Error;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Aug_25__2026__12_48_54_PM;
            pictureBox1.Location = new Point(132, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(74, 155);
            label4.Margin = new Padding(3, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(272, 18);
            label4.TabIndex = 49;
            label4.Text = "Are you sure you want to log out of";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(154, 173);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 50;
            label1.Text = "your account?";
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BorderColor = Color.FromArgb(193, 200, 207);
            btnCancel.BorderRadius = 10;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges1;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Transparent;
            btnCancel.FillColor2 = Color.Transparent;
            btnCancel.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(12, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(186, 51);
            btnCancel.TabIndex = 52;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Animated = true;
            btnLogOut.BorderRadius = 10;
            btnLogOut.CustomizableEdges = customizableEdges3;
            btnLogOut.DisabledState.BorderColor = Color.DarkGray;
            btnLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogOut.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogOut.FillColor = Color.FromArgb(95, 77, 214);
            btnLogOut.FillColor2 = Color.FromArgb(63, 41, 202);
            btnLogOut.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(218, 262);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogOut.Size = new Size(186, 51);
            btnLogOut.TabIndex = 51;
            btnLogOut.Text = "Log out";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmLogout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(425, 326);
            Controls.Add(btnCancel);
            Controls.Add(btnLogOut);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(guna2Separator2);
            Controls.Add(lblPrice);
            Controls.Add(pictureBox1);
            Name = "frmLogout";
            Text = "frmLogout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label lblPrice;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogOut;
    }
}