namespace PiStore
{
    partial class Menu
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
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(75, 84);
			this.label1.Margin = new System.Windows.Forms.Padding(2);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(366, 177);
			this.label1.TabIndex = 10;
			this.label1.Text = "PI STORE\r\nMENU";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.billToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(521, 28);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.productToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.employeeToolStripMenuItem.Text = "Employee";
			this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
			// 
			// clientToolStripMenuItem
			// 
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.clientToolStripMenuItem.Text = "Client";
			this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
			// 
			// productToolStripMenuItem
			// 
			this.productToolStripMenuItem.Name = "productToolStripMenuItem";
			this.productToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.productToolStripMenuItem.Text = "Product";
			this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
			// 
			// ordersToolStripMenuItem
			// 
			this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.manageOrderToolStripMenuItem});
			this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.ordersToolStripMenuItem.Text = "Orders";
			// 
			// placeOrderToolStripMenuItem
			// 
			this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
			this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
			this.placeOrderToolStripMenuItem.Text = "Place Order";
			this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
			// 
			// manageOrderToolStripMenuItem
			// 
			this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
			this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
			this.manageOrderToolStripMenuItem.Text = "Manage Order";
			this.manageOrderToolStripMenuItem.Click += new System.EventHandler(this.manageOrderToolStripMenuItem_Click);
			// 
			// billToolStripMenuItem
			// 
			this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printBillToolStripMenuItem});
			this.billToolStripMenuItem.Name = "billToolStripMenuItem";
			this.billToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.billToolStripMenuItem.Text = "Bill";
			// 
			// printBillToolStripMenuItem
			// 
			this.printBillToolStripMenuItem.Name = "printBillToolStripMenuItem";
			this.printBillToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
			this.printBillToolStripMenuItem.Text = "Print Bill";
			this.printBillToolStripMenuItem.Click += new System.EventHandler(this.printBillToolStripMenuItem_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(521, 325);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "Menu";
			this.Text = "Menu";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBillToolStripMenuItem;
    }
}