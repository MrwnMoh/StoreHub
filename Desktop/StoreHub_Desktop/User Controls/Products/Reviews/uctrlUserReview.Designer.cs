namespace StoreHub_Desktop.User_Controls.Products.Reviews
{
    partial class uctrlUserReview
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            v = new Guna.UI2.WinForms.Guna2Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDate = new Label();
            lblEdited = new Label();
            lblDotsBtnInfo = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lblReviewText = new Label();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            lblName = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            v.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // v
            // 
            v.Controls.Add(flowLayoutPanel1);
            v.Controls.Add(lblDotsBtnInfo);
            v.Controls.Add(guna2Separator1);
            v.Controls.Add(lblReviewText);
            v.Controls.Add(guna2RatingStar1);
            v.Controls.Add(lblName);
            v.Controls.Add(guna2CirclePictureBox1);
            v.CustomizableEdges = customizableEdges5;
            v.FillColor = Color.White;
            v.Location = new Point(0, 0);
            v.Name = "v";
            v.ShadowDecoration.CustomizableEdges = customizableEdges6;
            v.Size = new Size(855, 97);
            v.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblDate);
            flowLayoutPanel1.Controls.Add(lblEdited);
            flowLayoutPanel1.Location = new Point(157, 31);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(343, 22);
            flowLayoutPanel1.TabIndex = 36;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.DarkGray;
            lblDate.Location = new Point(3, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 21);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date";
            // 
            // lblEdited
            // 
            lblEdited.AutoSize = true;
            lblEdited.BackColor = Color.Transparent;
            lblEdited.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdited.ForeColor = Color.DarkGray;
            lblEdited.Location = new Point(55, 0);
            lblEdited.Name = "lblEdited";
            lblEdited.Size = new Size(71, 21);
            lblEdited.TabIndex = 35;
            lblEdited.Text = "(Edited)";
            lblEdited.Visible = false;
            // 
            // lblDotsBtnInfo
            // 
            lblDotsBtnInfo.AutoSize = true;
            lblDotsBtnInfo.BackColor = Color.Transparent;
            lblDotsBtnInfo.Font = new Font("VIP Hala Bold", 12F);
            lblDotsBtnInfo.ForeColor = Color.DarkGray;
            lblDotsBtnInfo.Location = new Point(801, 31);
            lblDotsBtnInfo.Name = "lblDotsBtnInfo";
            lblDotsBtnInfo.Size = new Size(37, 30);
            lblDotsBtnInfo.TabIndex = 30;
            lblDotsBtnInfo.Text = ". . .";
            lblDotsBtnInfo.Click += lblDotsBtnInfo_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(14, 83);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(827, 17);
            guna2Separator1.TabIndex = 28;
            // 
            // lblReviewText
            // 
            lblReviewText.BackColor = Color.Transparent;
            lblReviewText.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviewText.ForeColor = Color.Black;
            lblReviewText.Location = new Point(59, 56);
            lblReviewText.Name = "lblReviewText";
            lblReviewText.Size = new Size(779, 28);
            lblReviewText.TabIndex = 27;
            lblReviewText.Text = "Text Text Text ";
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(59, 31);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.RatingColor = Color.FromArgb(250, 192, 96);
            guna2RatingStar1.ReadOnly = true;
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
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(50, 50);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // uctrlUserReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(v);
            Name = "uctrlUserReview";
            Size = new Size(855, 97);
            v.ResumeLayout(false);
            v.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel v;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Label lblDate;
        private Label lblReviewText;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label lblDotsBtnInfo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lblEdited;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
