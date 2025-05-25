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
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }
        int currentUserId;
        public FormAdminDashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
    }
}
