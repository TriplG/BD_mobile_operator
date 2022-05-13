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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new AddClientForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new orderSCardForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new AddTariffForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new AddService();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new UserForm();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new AddProductForm();
            frm.Show();
        }
    }
}
