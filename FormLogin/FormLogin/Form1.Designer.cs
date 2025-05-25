namespace FormLogin
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
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            button3 = new Button();
            cmbPortal = new ComboBox();
            label3 = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F);
            label1.Location = new Point(385, 300);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 0;
            label1.Text = "用户名";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft YaHei UI", 14F);
            txtUsername.Location = new Point(500, 294);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(498, 43);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 14F);
            txtPassword.Location = new Point(500, 489);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(498, 43);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F);
            label2.Location = new Point(385, 489);
            label2.Name = "label2";
            label2.Size = new Size(71, 36);
            label2.TabIndex = 2;
            label2.Text = "密码";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            btnLogin.Location = new Point(277, 905);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 69);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            btnRegister.Location = new Point(716, 905);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(146, 69);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "注册";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            button3.Location = new Point(1119, 905);
            button3.Name = "button3";
            button3.Size = new Size(146, 69);
            button3.TabIndex = 6;
            button3.Text = "退出";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cmbPortal
            // 
            cmbPortal.Font = new Font("Microsoft YaHei UI", 14F);
            cmbPortal.FormattingEnabled = true;
            cmbPortal.Items.AddRange(new object[] { "学生端", "教师端", "管理端" });
            cmbPortal.Location = new Point(736, 650);
            cmbPortal.Name = "cmbPortal";
            cmbPortal.Size = new Size(157, 44);
            cmbPortal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 14F);
            label3.Location = new Point(541, 654);
            label3.Name = "label3";
            label3.Size = new Size(127, 36);
            label3.TabIndex = 8;
            label3.Text = "选择端口";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(606, 793);
            lblError.Name = "lblError";
            lblError.Size = new Size(94, 36);
            lblError.TabIndex = 9;
            lblError.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 1144);
            Controls.Add(lblError);
            Controls.Add(label3);
            Controls.Add(cmbPortal);
            Controls.Add(button3);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Button btnRegister;
        private Button button3;
        private ComboBox cmbPortal;
        private Label label3;
        private Label lblError;
    }
}
