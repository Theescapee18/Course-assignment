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
    public partial class FormRegisterSelect : Form
    {
        public FormRegisterSelect()
        {
            InitializeComponent();
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            new FormRegisterStudent().ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            new FormRegisterTeacher().ShowDialog();
        }

        private void btnSocialWorker_Click(object sender, EventArgs e)
        {
            new FormRegisterSocial().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }
    }
}
