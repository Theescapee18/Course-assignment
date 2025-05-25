using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormStudentDashboard : Form
    {
        public FormStudentDashboard()
        {
            InitializeComponent();
        }
        int currentUserId;
        public FormStudentDashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
    }
}
