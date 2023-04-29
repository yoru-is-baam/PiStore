namespace PiStore
{
    partial class ManagePlaceOrder
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
            this.components = new System.ComponentModel.Container();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ClientName = new System.Windows.Forms.TextBox();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(207, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 52);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_productID
            // 
            this.txt_productID.Location = new System.Drawing.Point(101, 139);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(100, 26);
            this.txt_productID.TabIndex = 1;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(207, 139);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(196, 26);
            this.txt_ProductName.TabIndex = 3;
            // 
            // txt_ClientName
            // 
            this.txt_ClientName.Location = new System.Drawing.Point(101, 83);
            this.txt_ClientName.Name = "txt_ClientName";
            this.txt_ClientName.Size = new System.Drawing.Size(302, 26);
            this.txt_ClientName.TabIndex = 5;
            // 
            // txt_orderID
            // 
            this.txt_orderID.Location = new System.Drawing.Point(101, 37);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(100, 26);
            this.txt_orderID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.Quantity});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(566, 296);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(101, 199);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(100, 26);
            this.nud_quantity.TabIndex = 13;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(602, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(455, 363);
            this.dataGridView2.TabIndex = 14;
            // 
            // productBindingSource
            // 
            //this.productBindingSource.DataSource = typeof(PiStore.Product);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 8;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // ManagePlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 611);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.txt_ClientName);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.btn_add);
            this.Name = "ManagePlaceOrder";
            this.Text = "ManagePlaceOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ClientName;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}