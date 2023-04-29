namespace PiStore
{
	partial class ManageEmployee
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
			this.BtnView = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.EmailBox = new System.Windows.Forms.TextBox();
			this.PhoneBox = new System.Windows.Forms.TextBox();
			this.AddressBox = new System.Windows.Forms.TextBox();
			this.SalaryBox = new System.Windows.Forms.TextBox();
			this.HireDateBox = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.BtnExport = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnView
			// 
			this.BtnView.Location = new System.Drawing.Point(440, 93);
			this.BtnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnView.Name = "BtnView";
			this.BtnView.Size = new System.Drawing.Size(93, 34);
			this.BtnView.TabIndex = 0;
			this.BtnView.Text = "View";
			this.BtnView.UseVisualStyleBackColor = true;
			this.BtnView.Click += new System.EventHandler(this.btn_show_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.Location = new System.Drawing.Point(440, 19);
			this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(93, 34);
			this.BtnAdd.TabIndex = 2;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.Location = new System.Drawing.Point(588, 19);
			this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(93, 34);
			this.BtnDelete.TabIndex = 3;
			this.BtnDelete.Text = "Delete";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Phone";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Address";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Salary";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Hire Date";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(104, 19);
			this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(242, 22);
			this.NameBox.TabIndex = 10;
			// 
			// EmailBox
			// 
			this.EmailBox.Location = new System.Drawing.Point(104, 52);
			this.EmailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EmailBox.Name = "EmailBox";
			this.EmailBox.Size = new System.Drawing.Size(242, 22);
			this.EmailBox.TabIndex = 11;
			// 
			// PhoneBox
			// 
			this.PhoneBox.Location = new System.Drawing.Point(104, 84);
			this.PhoneBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PhoneBox.Name = "PhoneBox";
			this.PhoneBox.Size = new System.Drawing.Size(242, 22);
			this.PhoneBox.TabIndex = 12;
			// 
			// AddressBox
			// 
			this.AddressBox.Location = new System.Drawing.Point(104, 117);
			this.AddressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new System.Drawing.Size(242, 22);
			this.AddressBox.TabIndex = 13;
			// 
			// SalaryBox
			// 
			this.SalaryBox.Location = new System.Drawing.Point(104, 150);
			this.SalaryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalaryBox.Name = "SalaryBox";
			this.SalaryBox.Size = new System.Drawing.Size(242, 22);
			this.SalaryBox.TabIndex = 14;
			// 
			// HireDateBox
			// 
			this.HireDateBox.Location = new System.Drawing.Point(104, 182);
			this.HireDateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HireDateBox.Name = "HireDateBox";
			this.HireDateBox.Size = new System.Drawing.Size(242, 22);
			this.HireDateBox.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(372, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(323, 60);
			this.label7.TabIndex = 16;
			this.label7.Text = "MANAGE EMPLOYEE";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.Location = new System.Drawing.Point(588, 93);
			this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(93, 34);
			this.BtnUpdate.TabIndex = 17;
			this.BtnUpdate.Text = "Update";
			this.BtnUpdate.UseVisualStyleBackColor = true;
			this.BtnUpdate.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.BackColor = System.Drawing.Color.CornflowerBlue;
			this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchBox.ForeColor = System.Drawing.Color.White;
			this.SearchBox.Location = new System.Drawing.Point(104, 219);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(242, 36);
			this.SearchBox.TabIndex = 19;
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(12, 218);
			this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(93, 34);
			this.BtnSearch.TabIndex = 20;
			this.BtnSearch.Text = "Search ID";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// BtnExport
			// 
			this.BtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnExport.Location = new System.Drawing.Point(700, 174);
			this.BtnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnExport.Name = "BtnExport";
			this.BtnExport.Size = new System.Drawing.Size(90, 29);
			this.BtnExport.TabIndex = 23;
			this.BtnExport.Text = "ExportCSV";
			this.BtnExport.UseVisualStyleBackColor = false;
			this.BtnExport.Click += new System.EventHandler(this.btn_export_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 257);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(748, 264);
			this.dataGridView.TabIndex = 1;
			this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// ManageEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 571);
			this.Controls.Add(this.BtnExport);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.HireDateBox);
			this.Controls.Add(this.SalaryBox);
			this.Controls.Add(this.AddressBox);
			this.Controls.Add(this.PhoneBox);
			this.Controls.Add(this.EmailBox);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.BtnView);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ManageEmployee";
			this.Text = "ManageEmployee";
			this.Load += new System.EventHandler(this.ManageEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnView;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox EmailBox;
		private System.Windows.Forms.TextBox PhoneBox;
		private System.Windows.Forms.TextBox AddressBox;
		private System.Windows.Forms.TextBox SalaryBox;
		private System.Windows.Forms.DateTimePicker HireDateBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.Button BtnExport;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}