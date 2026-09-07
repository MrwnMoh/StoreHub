namespace StoreHub_Desktop.User_Controls.Order
{
    partial class uctrlOrderRowSummary
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cxmsOrderStatus = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            processingToolStripMenuItem = new ToolStripMenuItem();
            shippedToolStripMenuItem = new ToolStripMenuItem();
            deliveredToolStripMenuItem = new ToolStripMenuItem();
            btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            uctrlOrderStatus1 = new uctrlOrderStatus();
            btnViewDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            lblOrderTotal = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblOrderItems = new Label();
            pictureBox3 = new PictureBox();
            lblOrderHour = new Label();
            lblOrderDate = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblOrderNumber = new Label();
            lblHomeLine = new Label();
            guna2Panel1.SuspendLayout();
            cxmsOrderStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.ContextMenuStrip = cxmsOrderStatus;
            guna2Panel1.Controls.Add(btnDelete);
            guna2Panel1.Controls.Add(uctrlOrderStatus1);
            guna2Panel1.Controls.Add(btnViewDetails);
            guna2Panel1.Controls.Add(lblOrderTotal);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(lblOrderItems);
            guna2Panel1.Controls.Add(pictureBox3);
            guna2Panel1.Controls.Add(lblOrderHour);
            guna2Panel1.Controls.Add(lblOrderDate);
            guna2Panel1.Controls.Add(pictureBox2);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblOrderNumber);
            guna2Panel1.Controls.Add(lblHomeLine);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1500, 141);
            guna2Panel1.TabIndex = 0;
            // 
            // cxmsOrderStatus
            // 
            cxmsOrderStatus.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            cxmsOrderStatus.Items.AddRange(new ToolStripItem[] { processingToolStripMenuItem, shippedToolStripMenuItem, deliveredToolStripMenuItem });
            cxmsOrderStatus.Name = "cxmsOrderStatus";
            cxmsOrderStatus.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cxmsOrderStatus.RenderStyle.BorderColor = Color.Gainsboro;
            cxmsOrderStatus.RenderStyle.ColorTable = null;
            cxmsOrderStatus.RenderStyle.RoundedEdges = true;
            cxmsOrderStatus.RenderStyle.SelectionArrowColor = Color.White;
            cxmsOrderStatus.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cxmsOrderStatus.RenderStyle.SelectionForeColor = Color.White;
            cxmsOrderStatus.RenderStyle.SeparatorColor = Color.Gainsboro;
            cxmsOrderStatus.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cxmsOrderStatus.Size = new Size(181, 94);
            cxmsOrderStatus.Opening += cxmsOrderStatus_Opening;
            // 
            // processingToolStripMenuItem
            // 
            processingToolStripMenuItem.BackColor = Color.FromArgb(232, 242, 255);
            processingToolStripMenuItem.ForeColor = Color.FromArgb(7, 99, 235);
            processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            processingToolStripMenuItem.Size = new Size(180, 30);
            processingToolStripMenuItem.Text = "Processing";
            processingToolStripMenuItem.Click += processingToolStripMenuItem_Click;
            // 
            // shippedToolStripMenuItem
            // 
            shippedToolStripMenuItem.BackColor = Color.FromArgb(239, 235, 255);
            shippedToolStripMenuItem.ForeColor = Color.FromArgb(99, 76, 255);
            shippedToolStripMenuItem.Name = "shippedToolStripMenuItem";
            shippedToolStripMenuItem.Size = new Size(180, 30);
            shippedToolStripMenuItem.Text = "Shipped";
            shippedToolStripMenuItem.Click += shippedToolStripMenuItem_Click;
            // 
            // deliveredToolStripMenuItem
            // 
            deliveredToolStripMenuItem.BackColor = Color.FromArgb(232, 247, 235);
            deliveredToolStripMenuItem.ForeColor = Color.FromArgb(22, 163, 74);
            deliveredToolStripMenuItem.Name = "deliveredToolStripMenuItem";
            deliveredToolStripMenuItem.Size = new Size(180, 30);
            deliveredToolStripMenuItem.Text = "Delivered";
            deliveredToolStripMenuItem.Click += deliveredToolStripMenuItem_Click;
            // 
            // btnDelete
            // 
            btnDelete.Animated = true;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderRadius = 5;
            btnDelete.ContextMenuStrip = cxmsOrderStatus;
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Firebrick;
            btnDelete.FillColor2 = Color.Red;
            btnDelete.Font = new Font("Nirmala Text", 11.25F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.Cancelled;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(30, 30);
            btnDelete.Location = new Point(1325, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(161, 39);
            btnDelete.TabIndex = 56;
            btnDelete.Text = "Cancel";
            btnDelete.Click += btnDelete_Click;
            // 
            // uctrlOrderStatus1
            // 
            uctrlOrderStatus1.BackColor = Color.Transparent;
            uctrlOrderStatus1.ContextMenuStrip = cxmsOrderStatus;
            uctrlOrderStatus1.Location = new Point(901, 60);
            uctrlOrderStatus1.Name = "uctrlOrderStatus1";
            uctrlOrderStatus1.Size = new Size(132, 40);
            uctrlOrderStatus1.Status = uctrlOrderStatus.eStatus.Pending;
            uctrlOrderStatus1.TabIndex = 55;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Animated = true;
            btnViewDetails.BorderColor = Color.FromArgb(95, 77, 214);
            btnViewDetails.BorderRadius = 8;
            btnViewDetails.BorderThickness = 1;
            btnViewDetails.ContextMenuStrip = cxmsOrderStatus;
            btnViewDetails.CustomizableEdges = customizableEdges3;
            btnViewDetails.DisabledState.BorderColor = Color.DarkGray;
            btnViewDetails.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewDetails.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewDetails.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnViewDetails.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewDetails.FillColor = Color.Transparent;
            btnViewDetails.FillColor2 = Color.Transparent;
            btnViewDetails.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = Color.FromArgb(95, 77, 214);
            btnViewDetails.Location = new Point(1325, 40);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnViewDetails.Size = new Size(161, 43);
            btnViewDetails.TabIndex = 54;
            btnViewDetails.Text = "View Details";
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.BackColor = Color.White;
            lblOrderTotal.ContextMenuStrip = cxmsOrderStatus;
            lblOrderTotal.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderTotal.ForeColor = Color.Black;
            lblOrderTotal.Location = new Point(1118, 58);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(83, 25);
            lblOrderTotal.TabIndex = 53;
            lblOrderTotal.Text = "$000.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ContextMenuStrip = cxmsOrderStatus;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(1118, 40);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 52;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ContextMenuStrip = cxmsOrderStatus;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(901, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 51;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ContextMenuStrip = cxmsOrderStatus;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(721, 40);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 50;
            label2.Text = "Items";
            // 
            // lblOrderItems
            // 
            lblOrderItems.AutoSize = true;
            lblOrderItems.BackColor = Color.White;
            lblOrderItems.ContextMenuStrip = cxmsOrderStatus;
            lblOrderItems.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderItems.ForeColor = Color.Black;
            lblOrderItems.Location = new Point(721, 58);
            lblOrderItems.Name = "lblOrderItems";
            lblOrderItems.Size = new Size(97, 25);
            lblOrderItems.TabIndex = 49;
            lblOrderItems.Text = "000 items";
            // 
            // pictureBox3
            // 
            pictureBox3.ContextMenuStrip = cxmsOrderStatus;
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_Aug_23__2026__07_09_23_PM__2_;
            pictureBox3.Location = new Point(635, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // lblOrderHour
            // 
            lblOrderHour.AutoSize = true;
            lblOrderHour.BackColor = Color.White;
            lblOrderHour.ContextMenuStrip = cxmsOrderStatus;
            lblOrderHour.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderHour.ForeColor = Color.DarkGray;
            lblOrderHour.Location = new Point(439, 83);
            lblOrderHour.Name = "lblOrderHour";
            lblOrderHour.Size = new Size(58, 17);
            lblOrderHour.TabIndex = 47;
            lblOrderHour.Text = "00:00 00";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.BackColor = Color.White;
            lblOrderDate.ContextMenuStrip = cxmsOrderStatus;
            lblOrderDate.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.Black;
            lblOrderDate.Location = new Point(437, 58);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(110, 25);
            lblOrderDate.TabIndex = 46;
            lblOrderDate.Text = "00 00 0000";
            // 
            // pictureBox2
            // 
            pictureBox2.ContextMenuStrip = cxmsOrderStatus;
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_Aug_19__2026__08_37_16_PM__7_;
            pictureBox2.Location = new Point(342, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = cxmsOrderStatus;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Aug_23__2026__07_09_23_PM__1_;
            pictureBox1.Location = new Point(15, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ContextMenuStrip = cxmsOrderStatus;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(437, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 43;
            label1.Text = "Order Number";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.BackColor = Color.White;
            lblOrderNumber.ContextMenuStrip = cxmsOrderStatus;
            lblOrderNumber.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.ForeColor = Color.Black;
            lblOrderNumber.Location = new Point(101, 58);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(178, 37);
            lblOrderNumber.TabIndex = 42;
            lblOrderNumber.Text = "Order #0000";
            // 
            // lblHomeLine
            // 
            lblHomeLine.AutoSize = true;
            lblHomeLine.BackColor = Color.White;
            lblHomeLine.ContextMenuStrip = cxmsOrderStatus;
            lblHomeLine.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomeLine.ForeColor = Color.DarkGray;
            lblHomeLine.Location = new Point(101, 40);
            lblHomeLine.Name = "lblHomeLine";
            lblHomeLine.Size = new Size(97, 17);
            lblHomeLine.TabIndex = 41;
            lblHomeLine.Text = "Order Number";
            // 
            // uctrlOrderRowSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "uctrlOrderRowSummary";
            Size = new Size(1500, 144);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            cxmsOrderStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblHomeLine;
        private Label label1;
        private Label lblOrderNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblOrderItems;
        private PictureBox pictureBox3;
        private Label lblOrderHour;
        private Label lblOrderDate;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblOrderTotal;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewDetails;
        private uctrlOrderStatus uctrlOrderStatus1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cxmsOrderStatus;
        private ToolStripMenuItem processingToolStripMenuItem;
        private ToolStripMenuItem shippedToolStripMenuItem;
        private ToolStripMenuItem deliveredToolStripMenuItem;
    }
}
