namespace FormLogin
{
    partial class FormRegisterSelect
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
            label1 = new Label();
            btnStudent = new Button();
            btnTeacher = new Button();
            btnSocialWorker = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            label1.Location = new Point(379, 98);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "请选择注册身份";
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            btnStudent.Location = new Point(106, 322);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(136, 60);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "学生";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            btnTeacher.Location = new Point(308, 322);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(126, 60);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "教师";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSocialWorker
            // 
            btnSocialWorker.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            btnSocialWorker.Location = new Point(510, 322);
            btnSocialWorker.Name = "btnSocialWorker";
            btnSocialWorker.Size = new Size(176, 60);
            btnSocialWorker.TabIndex = 3;
            btnSocialWorker.Text = "社会工作者";
            btnSocialWorker.UseVisualStyleBackColor = true;
            btnSocialWorker.Click += btnSocialWorker_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            button4.Location = new Point(732, 322);
            button4.Name = "button4";
            button4.Size = new Size(146, 60);
            button4.TabIndex = 4;
            button4.Text = "返回";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormRegisterSelect
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 551);
            Controls.Add(button4);
            Controls.Add(btnSocialWorker);
            Controls.Add(btnTeacher);
            Controls.Add(btnStudent);
            Controls.Add(label1);
            Name = "FormRegisterSelect";
            Text = "FormRegisterSelect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStudent;
        private Button btnTeacher;
        private Button btnSocialWorker;
        private Button button4;
    }
}