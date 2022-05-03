namespace do_an_oop_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.listLogin = new System.Windows.Forms.ListView();
            this.nameLogin = new System.Windows.Forms.ColumnHeader();
            this.passWord = new System.Windows.Forms.ColumnHeader();
            this.chucVu = new System.Windows.Forms.ColumnHeader();
            this.txtChooseTypeLogin = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Location = new System.Drawing.Point(176, 136);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(107, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "Tên đăng nhập";
            this.txtLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPw
            // 
            this.txtPw.AutoSize = true;
            this.txtPw.Location = new System.Drawing.Point(181, 183);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(70, 20);
            this.txtPw.TabIndex = 4;
            this.txtPw.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(291, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // listLogin
            // 
            this.listLogin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameLogin,
            this.passWord,
            this.chucVu});
            this.listLogin.FullRowSelect = true;
            this.listLogin.GridLines = true;
            this.listLogin.Location = new System.Drawing.Point(12, 311);
            this.listLogin.Name = "listLogin";
            this.listLogin.Size = new System.Drawing.Size(943, 140);
            this.listLogin.TabIndex = 6;
            this.listLogin.UseCompatibleStateImageBehavior = false;
            this.listLogin.View = System.Windows.Forms.View.Details;
            // 
            // nameLogin
            // 
            this.nameLogin.Text = "tên đăng nhập";
            this.nameLogin.Width = 150;
            // 
            // passWord
            // 
            this.passWord.Text = "mật khẩu";
            this.passWord.Width = 150;
            // 
            // chucVu
            // 
            this.chucVu.Text = "chucVu";
            this.chucVu.Width = 150;
            // 
            // txtChooseTypeLogin
            // 
            this.txtChooseTypeLogin.AutoSize = true;
            this.txtChooseTypeLogin.Location = new System.Drawing.Point(174, 100);
            this.txtChooseTypeLogin.Name = "txtChooseTypeLogin";
            this.txtChooseTypeLogin.Size = new System.Drawing.Size(109, 20);
            this.txtChooseTypeLogin.TabIndex = 8;
            this.txtChooseTypeLogin.Text = "loại đăng nhập";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "nhanVien"});
            this.comboBox1.Location = new System.Drawing.Point(289, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 475);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtChooseTypeLogin);
            this.Controls.Add(this.listLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label txtLogin;
        private Label txtPw;
        private Button btnLogin;
        private ListView listLogin;
        private ColumnHeader nameLogin;
        private ColumnHeader passWord;
        private Label txtChooseTypeLogin;
        private ComboBox comboBox1;
        private ColumnHeader chucVu;
    }
}