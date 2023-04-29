namespace PiStore
{
	partial class ManageClient
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
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.txt_Phone = new System.Windows.Forms.TextBox();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_show = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Button();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.btn_export = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_Address
			// 
			this.txt_Address.Location = new System.Drawing.Point(104, 115);
			this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.Size = new System.Drawing.Size(242, 22);
			this.txt_Address.TabIndex = 29;
			// 
			// txt_Phone
			// 
			this.txt_Phone.Location = new System.Drawing.Point(104, 82);
			this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Phone.Name = "txt_Phone";
			this.txt_Phone.Size = new System.Drawing.Size(242, 22);
			this.txt_Phone.TabIndex = 28;
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(104, 50);
			this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(242, 22);
			this.txt_Email.TabIndex = 27;
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(104, 18);
			this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(242, 22);
			this.txt_Name.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 16);
			this.label4.TabIndex = 23;
			this.label4.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "Phone";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Name";
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(587, 20);
			this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(93, 37);
			this.btn_delete.TabIndex = 19;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(438, 18);
			this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(93, 37);
			this.btn_add.TabIndex = 18;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(30, 198);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(672, 323);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// btn_show
			// 
			this.btn_show.Location = new System.Drawing.Point(438, 82);
			this.btn_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_show.Name = "btn_show";
			this.btn_show.Size = new System.Drawing.Size(93, 37);
			this.btn_show.TabIndex = 16;
			this.btn_show.Text = "View";
			this.btn_show.UseVisualStyleBackColor = true;
			this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(587, 82);
			this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(93, 37);
			this.btn_update.TabIndex = 30;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(351, 146);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(253, 42);
			this.label7.TabIndex = 31;
			this.label7.Text = "MANAGE CLIENT\r\n";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(5, 146);
			this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(93, 37);
			this.btn_search.TabIndex = 33;
			this.btn_search.Text = "Search ID";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// txt_search
			// 
			this.txt_search.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_search.ForeColor = System.Drawing.Color.White;
			this.txt_search.Location = new System.Drawing.Point(104, 148);
			this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(242, 36);
			this.txt_search.TabIndex = 32;
			// 
			// btn_export
			// 
			this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btn_export.Location = new System.Drawing.Point(614, 148);
			this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_export.Name = "btn_export";
			this.btn_export.Size = new System.Drawing.Size(88, 31);
			this.btn_export.TabIndex = 36;
			this.btn_export.Text = "ExportCSV";
			this.btn_export.UseVisualStyleBackColor = false;
			this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
			// 
			// ManageClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 542);
			this.Controls.Add(this.btn_export);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.txt_Address);
			this.Controls.Add(this.txt_Phone);
			this.Controls.Add(this.txt_Email);
			this.Controls.Add(this.txt_Name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_show);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ManageClient";
			this.Text = "ManageClient";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.TextBox txt_Phone;
		private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_show;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Button btn_export;
	}
}