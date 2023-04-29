namespace PiStore
{
    partial class ManageOrders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(717, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(43, 66);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(124, 44);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 49);
            this.label7.TabIndex = 43;
            this.label7.Text = "MANAGE ORDERS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(655, 66);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 43);
            this.btn_search.TabIndex = 48;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(416, 68);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 41);
            this.txt_search.TabIndex = 47;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_export.Location = new System.Drawing.Point(548, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(101, 36);
            this.btn_export.TabIndex = 50;
            this.btn_export.Text = "ExportCSV";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 425);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageOrders";
            this.Text = "ManageOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_export;
    }
}