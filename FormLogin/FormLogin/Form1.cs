using Microsoft.Data.SqlClient;
namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string selectedPortal = cmbPortal.SelectedItem.ToString();

            if (username == "" || password == "")
            {
                lblError.Text = "请输入用户名和密码。";
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT UserID, Role FROM Users WHERE Username=@u AND PasswordHash=@p";
                SqlCommand cmd =  new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    int userId = Convert.ToInt32(reader["UserID"]);

                    // 校验端口与角色是否一致
                    if ((selectedPortal == "学生端" && role != "学生") ||
                        (selectedPortal == "教师端" && role != "教师") ||
                        (selectedPortal == "管理端" && role != "管理员"))
                    {
                        lblError.Text = "所选端口与账号角色不匹配！";
                        return;
                    }

                    this.Hide();
                    if (role == "学生")
                        new FormStudentDashboard(userId).ShowDialog();
                    else if (role == "教师")
                        new FormTeacherDashboard(userId).ShowDialog();
                    else if (role == "管理员")
                        new FormAdminDashboard(userId).ShowDialog();
                    this.Show();
                }
                else
                {
                    lblError.Text = "用户名或密码错误。";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FormRegisterSelect().ShowDialog();
        }
    }
}
