namespace PiStore
{
    partial class Login
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
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// UsernameBox
			// 
			this.UsernameBox.Location = new System.Drawing.Point(178, 148);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(294, 23);
			this.UsernameBox.TabIndex = 0;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PasswordBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.PasswordBox.Location = new System.Drawing.Point(178, 225);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(294, 23);
			this.PasswordBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "USERNAME";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "PASSWORD";
			// 
			// BtnLogin
			// 
			this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLogin.Location = new System.Drawing.Point(178, 301);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(100, 40);
			this.BtnLogin.TabIndex = 4;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnClear.Location = new System.Drawing.Point(358, 301);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(100, 40);
			this.BtnClear.TabIndex = 5;
			this.BtnClear.Text = "Clear";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(68, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(433, 130);
			this.label7.TabIndex = 44;
			this.label7.Text = "--Welcome to--\r\nPi Store";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(558, 369);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.UsernameBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "Login";
			this.Text = "Login ";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label7;
    }
}

