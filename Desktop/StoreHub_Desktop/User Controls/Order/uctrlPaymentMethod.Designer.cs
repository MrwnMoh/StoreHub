namespace StoreHub_Desktop.User_Controls.Order
{
    partial class uctrlPaymentMethod
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label1 = new Label();
            guna2CustomRadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            lblProductName = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.FromArgb(193, 200, 207);
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(lblProductName);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(930, 162);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.FromArgb(242, 240, 254);
            guna2Panel2.BorderRadius = 10;
            guna2Panel2.Controls.Add(label2);
            guna2Panel2.Controls.Add(label1);
            guna2Panel2.Controls.Add(guna2CustomRadioButton1);
            guna2Panel2.CustomizableEdges = customizableEdges2;
            guna2Panel2.FillColor = Color.FromArgb(242, 240, 254);
            guna2Panel2.Location = new Point(18, 49);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(892, 93);
            guna2Panel2.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(64, 49);
            label2.Name = "label2";
            label2.Size = new Size(304, 25);
            label2.TabIndex = 45;
            label2.Text = "Pay when you receive your order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(64, 19);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 44;
            label1.Text = "Cash on Delivery";
            // 
            // guna2CustomRadioButton1
            // 
            guna2CustomRadioButton1.Animated = true;
            guna2CustomRadioButton1.Checked = true;
            guna2CustomRadioButton1.CheckedState.BorderColor = Color.FromArgb(106, 73, 236);
            guna2CustomRadioButton1.CheckedState.BorderThickness = 2;
            guna2CustomRadioButton1.CheckedState.FillColor = Color.White;
            guna2CustomRadioButton1.CheckedState.InnerColor = Color.FromArgb(106, 73, 236);
            guna2CustomRadioButton1.Location = new Point(20, 14);
            guna2CustomRadioButton1.Name = "guna2CustomRadioButton1";
            guna2CustomRadioButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CustomRadioButton1.Size = new Size(38, 42);
            guna2CustomRadioButton1.TabIndex = 43;
            guna2CustomRadioButton1.Text = "guna2CustomRadioButton1";
            guna2CustomRadioButton1.UncheckedState.BorderColor = Color.FromArgb(106, 73, 236);
            guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
            guna2CustomRadioButton1.UncheckedState.FillColor = Color.Transparent;
            guna2CustomRadioButton1.UncheckedState.InnerColor = Color.Transparent;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(18, 9);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(239, 37);
            lblProductName.TabIndex = 41;
            lblProductName.Text = "Payment Method";
            // 
            // uctrlPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrlPaymentMethod";
            Size = new Size(930, 167);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblProductName;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label2;
    }
}
