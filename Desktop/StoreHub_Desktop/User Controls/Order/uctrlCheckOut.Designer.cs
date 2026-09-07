namespace StoreHub_Desktop.User_Controls.Order
{
    partial class uctrlCheckOut
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
            uctrlOrderSummary1 = new uctrlOrderSummary();
            uctrlPaymentMethod1 = new uctrlPaymentMethod();
            btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            lblProductName = new Label();
            label1 = new Label();
            lblBtnBack = new Label();
            uctrlSelectOrderAddress2 = new uctrlSelectOrderAddress();
            SuspendLayout();
            // 
            // uctrlOrderSummary1
            // 
            uctrlOrderSummary1.BackColor = Color.Transparent;
            uctrlOrderSummary1.Location = new Point(16, 136);
            uctrlOrderSummary1.Name = "uctrlOrderSummary1";
            uctrlOrderSummary1.Size = new Size(642, 778);
            uctrlOrderSummary1.TabIndex = 0;
            // 
            // uctrlPaymentMethod1
            // 
            uctrlPaymentMethod1.BackColor = Color.Transparent;
            uctrlPaymentMethod1.Location = new Point(684, 847);
            uctrlPaymentMethod1.Name = "uctrlPaymentMethod1";
            uctrlPaymentMethod1.Size = new Size(930, 174);
            uctrlPaymentMethod1.TabIndex = 2;
            // 
            // btnCheckout
            // 
            btnCheckout.Animated = true;
            btnCheckout.BorderRadius = 10;
            btnCheckout.CustomizableEdges = customizableEdges1;
            btnCheckout.DisabledState.BorderColor = Color.DarkGray;
            btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckout.Enabled = false;
            btnCheckout.FillColor = Color.FromArgb(95, 77, 214);
            btnCheckout.FillColor2 = Color.FromArgb(63, 41, 202);
            btnCheckout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(16, 958);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCheckout.Size = new Size(642, 51);
            btnCheckout.TabIndex = 34;
            btnCheckout.Text = "Place Order";
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(46, 55, 68);
            lblProductName.Location = new Point(16, 68);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(136, 37);
            lblProductName.TabIndex = 36;
            lblProductName.Text = "Checkout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(23, 105);
            label1.Name = "label1";
            label1.Size = new Size(278, 17);
            label1.TabIndex = 37;
            label1.Text = "Review your items and complete your order";
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
            lblBtnBack.TabIndex = 38;
            lblBtnBack.Text = "‹ Back";
            lblBtnBack.Click += lblBtnBack_Click;
            // 
            // uctrlSelectOrderAddress2
            // 
            uctrlSelectOrderAddress2.BackColor = Color.Transparent;
            uctrlSelectOrderAddress2.Location = new Point(684, 136);
            uctrlSelectOrderAddress2.Name = "uctrlSelectOrderAddress2";
            uctrlSelectOrderAddress2.Size = new Size(930, 658);
            uctrlSelectOrderAddress2.TabIndex = 39;
            // 
            // uctrlCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(uctrlSelectOrderAddress2);
            Controls.Add(lblBtnBack);
            Controls.Add(label1);
            Controls.Add(lblProductName);
            Controls.Add(btnCheckout);
            Controls.Add(uctrlPaymentMethod1);
            Controls.Add(uctrlOrderSummary1);
            Name = "uctrlCheckOut";
            Size = new Size(1642, 1052);
            Load += uctrlCheckOut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private uctrlOrderSummary uctrlOrderSummary1;
        private uctrlSelectOrderAddress uctrlSelectOrderAddress1;
        private uctrlPaymentMethod uctrlPaymentMethod1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        private Label lblProductName;
        private Label label1;
        private Label lblBtnBack;
        private uctrlSelectOrderAddress uctrlSelectOrderAddress2;
    }
}
