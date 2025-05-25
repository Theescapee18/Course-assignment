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
                lblError.Text = "�������û��������롣";
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

                    // У��˿����ɫ�Ƿ�һ��
                    if ((selectedPortal == "ѧ����" && role != "ѧ��") ||
                        (selectedPortal == "��ʦ��" && role != "��ʦ") ||
                        (selectedPortal == "�����" && role != "����Ա"))
                    {
                        lblError.Text = "��ѡ�˿����˺Ž�ɫ��ƥ�䣡";
                        return;
                    }

                    this.Hide();
                    if (role == "ѧ��")
                        new FormStudentDashboard(userId).ShowDialog();
                    else if (role == "��ʦ")
                        new FormTeacherDashboard(userId).ShowDialog();
                    else if (role == "����Ա")
                        new FormAdminDashboard(userId).ShowDialog();
                    this.Show();
                }
                else
                {
                    lblError.Text = "�û������������";
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
