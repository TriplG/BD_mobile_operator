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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new WorkerCountForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new SwipeTariffForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new AddContactDataForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new AddServiceForm();
            frm.Show();
        }
    }
}
