using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_operator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonWorker_Click(object sender, EventArgs e)
        {
            Form frm = new PassForm();
            frm.Show();
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            Form frm = new UserForm();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
