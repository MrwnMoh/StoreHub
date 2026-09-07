namespace StoreHub_Desktop.User_Controls.Products.Reviews
{
    partial class uctrlWriteAReview
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            v = new Guna.UI2.WinForms.Guna2Panel();
            btnPost = new Guna.UI2.WinForms.Guna2GradientButton();
            txbReview = new Guna.UI2.WinForms.Guna2TextBox();
            lblDate = new Label();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            lblName = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            v.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // v
            // 
            v.BorderColor = Color.FromArgb(193, 200, 207);
            v.BorderRadius = 10;
            v.BorderThickness = 1;
            v.Controls.Add(btnPost);
            v.Controls.Add(txbReview);
            v.Controls.Add(lblDate);
            v.Controls.Add(guna2RatingStar1);
            v.Controls.Add(lblName);
            v.Controls.Add(guna2CirclePictureBox1);
            v.CustomizableEdges = customizableEdges6;
            v.FillColor = Color.White;
            v.Location = new Point(0, 0);
            v.Name = "v";
            v.ShadowDecoration.CustomizableEdges = customizableEdges7;
            v.Size = new Size(878, 155);
            v.TabIndex = 1;
            // 
            // btnPost
            // 
            btnPost.Animated = true;
            btnPost.BorderRadius = 5;
            btnPost.CustomizableEdges = customizableEdges1;
            btnPost.DisabledState.BorderColor = Color.DarkGray;
            btnPost.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPost.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPost.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnPost.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPost.FillColor = Color.FromArgb(95, 77, 214);
            btnPost.FillColor2 = Color.FromArgb(63, 41, 202);
            btnPost.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPost.ForeColor = Color.White;
            btnPost.Location = new Point(712, 102);
            btnPost.Name = "btnPost";
            btnPost.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPost.Size = new Size(150, 45);
            btnPost.TabIndex = 33;
            btnPost.Text = "Post Review";
            btnPost.Click += btnPost_Click;
            // 
            // txbReview
            // 
            txbReview.Animated = true;
            txbReview.AutoScroll = true;
            txbReview.AutoSize = true;
            txbReview.BorderThickness = 0;
            txbReview.CustomizableEdges = customizableEdges3;
            txbReview.DefaultText = "";
            txbReview.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbReview.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbReview.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbReview.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbReview.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbReview.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbReview.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbReview.Location = new Point(59, 52);
            txbReview.Margin = new Padding(3, 4, 3, 4);
            txbReview.MaxLength = 500;
            txbReview.Multiline = true;
            txbReview.Name = "txbReview";
            txbReview.PlaceholderText = "Share your thoughts about this product...";
            txbReview.SelectedText = "";
            txbReview.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txbReview.Size = new Size(803, 45);
            txbReview.TabIndex = 27;
            txbReview.TextChanged += txbReview_TextChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.DarkGray;
            lblDate.Location = new Point(157, 31);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 21);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date";
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(59, 31);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.RatingColor = Color.FromArgb(250, 192, 96);
            guna2RatingStar1.Size = new Size(92, 22);
            guna2RatingStar1.TabIndex = 25;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(46, 55, 68);
            lblName.Location = new Point(59, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 22;
            lblName.Text = "Name";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.FillColor = Color.Black;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(3, 3);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(50, 50);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // uctrlWriteAReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(v);
            Name = "uctrlWriteAReview";
            Size = new Size(878, 155);
            v.ResumeLayout(false);
            v.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel v;
        private Label lblDate;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txbReview;
        private Guna.UI2.WinForms.Guna2GradientButton btnPost;
    }
}
