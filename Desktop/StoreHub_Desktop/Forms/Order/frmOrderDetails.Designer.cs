namespace StoreHub_Desktop.User_Controls.Order
{
    partial class frmOrderDetails
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
            uctrlOrderSummary1 = new uctrlOrderSummary();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            uctrlOrderStatus1 = new uctrlOrderStatus();
            lblSippingAdress = new Label();
            lblBtnBack = new Label();
            lblBtnExit = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uctrlOrderSummary1
            // 
            uctrlOrderSummary1.BackColor = Color.Transparent;
            uctrlOrderSummary1.Location = new Point(31, 25);
            uctrlOrderSummary1.Name = "uctrlOrderSummary1";
            uctrlOrderSummary1.Size = new Size(642, 777);
            uctrlOrderSummary1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(uctrlOrderStatus1);
            guna2Panel1.Controls.Add(lblSippingAdress);
            guna2Panel1.Controls.Add(lblBtnBack);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(31, 808);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(642, 152);
            guna2Panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 106);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 42;
            label2.Text = "Order Status:";
            // 
            // uctrlOrderStatus1
            // 
            uctrlOrderStatus1.BackColor = Color.Transparent;
            uctrlOrderStatus1.Location = new Point(158, 100);
            uctrlOrderStatus1.Name = "uctrlOrderStatus1";
            uctrlOrderStatus1.Size = new Size(132, 40);
            uctrlOrderStatus1.Status = uctrlOrderStatus.eStatus.Pending;
            uctrlOrderStatus1.TabIndex = 41;
            // 
            // lblSippingAdress
            // 
            lblSippingAdress.BackColor = Color.Transparent;
            lblSippingAdress.Cursor = Cursors.Hand;
            lblSippingAdress.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSippingAdress.ForeColor = Color.DarkGray;
            lblSippingAdress.Location = new Point(19, 44);
            lblSippingAdress.Name = "lblSippingAdress";
            lblSippingAdress.Size = new Size(595, 54);
            lblSippingAdress.TabIndex = 40;
            lblSippingAdress.Text = "Shipping Adress";
            // 
            // lblBtnBack
            // 
            lblBtnBack.AutoSize = true;
            lblBtnBack.BackColor = Color.Transparent;
            lblBtnBack.Cursor = Cursors.Hand;
            lblBtnBack.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnBack.ForeColor = Color.Black;
            lblBtnBack.Location = new Point(19, 16);
            lblBtnBack.Name = "lblBtnBack";
            lblBtnBack.Size = new Size(156, 25);
            lblBtnBack.TabIndex = 39;
            lblBtnBack.Text = "Shipping Adress";
            // 
            // lblBtnExit
            // 
            lblBtnExit.AutoSize = true;
            lblBtnExit.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtnExit.ForeColor = Color.FromArgb(64, 64, 64);
            lblBtnExit.Location = new Point(673, 9);
            lblBtnExit.Name = "lblBtnExit";
            lblBtnExit.Size = new Size(37, 37);
            lblBtnExit.TabIndex = 2;
            lblBtnExit.Text = "×";
            lblBtnExit.Click += lblBtnExit_Click;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(710, 984);
            Controls.Add(lblBtnExit);
            Controls.Add(guna2Panel1);
            Controls.Add(uctrlOrderSummary1);
            Name = "frmOrderDetails";
            Text = "frmOrderDetails";
            Load += frmOrderDetails_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private uctrlOrderSummary uctrlOrderSummary1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblBtnBack;
        private Label label2;
        private uctrlOrderStatus uctrlOrderStatus1;
        private Label lblSippingAdress;
        private Label lblBtnExit;
    }
}