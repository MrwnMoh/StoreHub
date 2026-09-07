namespace StoreHub_Desktop.User_Controls.Seller
{
    partial class uctrlSqueareStoreCard
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pbCardImage = new PictureBox();
            lblContanint = new Label();
            lblCardName = new Label();
            lblCardLine = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCardImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.Controls.Add(pbCardImage);
            guna2Panel1.Controls.Add(lblContanint);
            guna2Panel1.Controls.Add(lblCardName);
            guna2Panel1.Controls.Add(lblCardLine);
            guna2Panel1.Cursor = Cursors.Hand;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(264, 206);
            guna2Panel1.TabIndex = 0;
            // 
            // pbCardImage
            // 
            pbCardImage.Cursor = Cursors.Hand;
            pbCardImage.Image = Properties.Resources.Users;
            pbCardImage.Location = new Point(23, 17);
            pbCardImage.Name = "pbCardImage";
            pbCardImage.Size = new Size(70, 70);
            pbCardImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbCardImage.TabIndex = 45;
            pbCardImage.TabStop = false;
            // 
            // lblContanint
            // 
            lblContanint.AutoSize = true;
            lblContanint.BackColor = Color.Transparent;
            lblContanint.Cursor = Cursors.Hand;
            lblContanint.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContanint.ForeColor = Color.FromArgb(95, 77, 214);
            lblContanint.Location = new Point(13, 130);
            lblContanint.Name = "lblContanint";
            lblContanint.Size = new Size(97, 30);
            lblContanint.TabIndex = 44;
            lblContanint.Text = "0000000";
            // 
            // lblCardName
            // 
            lblCardName.AutoSize = true;
            lblCardName.BackColor = Color.Transparent;
            lblCardName.Cursor = Cursors.Hand;
            lblCardName.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardName.ForeColor = Color.Black;
            lblCardName.Location = new Point(13, 90);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new Size(118, 30);
            lblCardName.TabIndex = 43;
            lblCardName.Text = "Card name";
            // 
            // lblCardLine
            // 
            lblCardLine.AutoSize = true;
            lblCardLine.BackColor = Color.Transparent;
            lblCardLine.Cursor = Cursors.Hand;
            lblCardLine.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardLine.ForeColor = Color.FromArgb(46, 55, 68);
            lblCardLine.Location = new Point(14, 170);
            lblCardLine.Name = "lblCardLine";
            lblCardLine.Size = new Size(96, 25);
            lblCardLine.TabIndex = 42;
            lblCardLine.Text = "Card Line";
            // 
            // uctrlSqueareStoreCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrlSqueareStoreCard";
            Size = new Size(269, 211);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCardImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblContanint;
        private Label lblCardName;
        private Label lblCardLine;
        private PictureBox pbCardImage;
    }
}
