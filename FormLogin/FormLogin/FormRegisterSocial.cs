using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormRegisterSocial : Form
    {
        // 角色类型枚举
        private enum UserRole { Student, Teacher, Researcher, SocialWorker }

        public FormRegisterSocial()
        {
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            // 基础控件设置
            this.Text = "拼图考试系统 - 用户注册";
            this.Size = new Size(500, 600);
            this.BackColor = Color.White;

            // 角色选择
            lblRole.Text = "用户角色:";
            cmbRole.Items.AddRange(new object[] { "学生", "教师", "科研人员", "社会工作者" });
            cmbRole.SelectedIndex = 0;
            cmbRole.SelectedIndexChanged += CmbRole_SelectedIndexChanged;

            // 多语言选择
            lblLanguages.Text = "掌握语言:";
            clbLanguages.Items.AddRange(new object[] { 
                "C/C++", "C#", "Java", "Python", 
                "JavaScript", "SQL", "Rust", "TypeScript" 
            });

            // 教师专属字段（默认隐藏）
            lblTitle.Visible = false;
            txtTitle.Visible = false;
            lblPermission.Visible = false;
            cmbPermission.Visible = false;

            // 权限等级选项
            cmbPermission.Items.AddRange(new object[] { "初级", "中级", "高级" });
            cmbPermission.SelectedIndex = 0;

            // 按钮设置
            btnRegister.Text = "注册";
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Text = "取消";
            btnCancel.Click += (s, e) => this.Close();
        }

        // 角色选择变化事件
        private void CmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isTeacher = cmbRole.SelectedItem.ToString() == "教师";
            
            // 动态显示/隐藏教师专属字段
            lblTitle.Visible = isTeacher;
            txtTitle.Visible = isTeacher;
            lblPermission.Visible = isTeacher;
            cmbPermission.Visible = isTeacher;

            // 调整布局
            if (isTeacher) this.Height = 650;
            else this.Height = 600;
        }

        // 注册按钮事件
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // 验证逻辑
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("用户名和密码不能为空", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("两次输入的密码不一致", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 收集注册数据
            var userData = new Dictionary<string, string>
            {
                { "Username", txtUsername.Text },
                { "Email", txtEmail.Text },
                { "Role", cmbRole.SelectedItem.ToString() }
            };

            // 收集选择的语言
            var selectedLanguages = new List<string>();
            foreach (var item in clbLanguages.CheckedItems)
            {
                selectedLanguages.Add(item.ToString());
            }

            // 如果是教师，添加额外信息
            if (cmbRole.SelectedItem.ToString() == "教师")
            {
                userData.Add("Title", txtTitle.Text);
                userData.Add("PermissionLevel", cmbPermission.SelectedItem.ToString());
            }

            // TODO: 实际注册逻辑（数据库插入等）
            MessageBox.Show("注册成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // 以下是控件声明（实际在Designer.cs文件中）
        private Label lblUsername = new Label { Text = "用户名:", Location = new Point(50, 30) };
        private TextBox txtUsername = new TextBox { Location = new Point(150, 30), Width = 200 };
        
        private Label lblPassword = new Label { Text = "密码:", Location = new Point(50, 70) };
        private TextBox txtPassword = new TextBox { Location = new Point(150, 70), Width = 200, PasswordChar = '*' };
        
        private Label lblConfirmPassword = new Label { Text = "确认密码:", Location = new Point(50, 110) };
        private TextBox txtConfirmPassword = new TextBox { Location = new Point(150, 110), Width = 200, PasswordChar = '*' };
        
        private Label lblEmail = new Label { Text = "邮箱:", Location = new Point(50, 150) };
        private TextBox txtEmail = new TextBox { Location = new Point(150, 150), Width = 200 };
        
        private Label lblRole = new Label { Text = "用户角色:", Location = new Point(50, 190) };
        private ComboBox cmbRole = new ComboBox { Location = new Point(150, 190), Width = 200 };
        
        private Label lblLanguages = new Label { Text = "掌握语言:", Location = new Point(50, 230) };
        private CheckedListBox clbLanguages = new CheckedListBox { 
            Location = new Point(150, 230), 
            Size = new Size(200, 100),
            CheckOnClick = true
        };
        
