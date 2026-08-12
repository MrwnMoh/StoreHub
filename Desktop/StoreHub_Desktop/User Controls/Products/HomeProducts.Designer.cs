namespace StoreHub_Desktop.User_Controls.Products
{
    partial class HomeProducts
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
            flpContaner = new FlowLayoutPanel();
            lblProductName = new Label();
            label1 = new Label();
            lblShowingInfo = new Label();
            SuspendLayout();
            // 
            // flpContaner
            // 
            flpContaner.Location = new Point(3, 95);
            flpContaner.Name = "flpContaner";
            flpContaner.Size = new Size(1502, 1412);
            flpContaner.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Cursor = Cursors.Hand;
            lblProductName.Font = new Font("Nunito", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(175, 153, 246);
            lblProductName.Location = new Point(1402, 45);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(89, 26);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "View All";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 55, 68);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 17;
            label1.Text = "Products";
            // 
            // lblShowingInfo
            // 
            lblShowingInfo.AutoSize = true;
            lblShowingInfo.BackColor = Color.Transparent;
            lblShowingInfo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowingInfo.ForeColor = Color.DarkGray;
            lblShowingInfo.Location = new Point(15, 50);
            lblShowingInfo.Name = "lblShowingInfo";
            lblShowingInfo.Size = new Size(212, 21);
            lblShowingInfo.TabIndex = 18;
            lblShowingInfo.Text = "Showing -- of ---- products";
            // 
            // HomeProducts
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Transparent;
            Controls.Add(lblShowingInfo);
            Controls.Add(label1);
            Controls.Add(lblProductName);
            Controls.Add(flpContaner);
            Name = "HomeProducts";
            Size = new Size(1512, 1525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpContaner;
        private Label lblProductName;
        private Label label1;
        private Label lblShowingInfo;
    }
}
