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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new orderSCardForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@FIO"].Value = textBox1.Text;
            sqlCommand1.Parameters["@DB_client"].Value = dateTimePicker1.Value;
            //sqlCommand1.Parameters["@date"].Value = dateTimePicker1.Text;
            sqlCommand1.Parameters["@Pasport"].Value = textBox3.Text;
            sqlCommand1.Parameters["@Adress"].Value = textBox4.Text;
            sqlCommand1.Parameters["@FIO_Worker"].Value = textBox6.Text;
            sqlCommand1.Parameters["@number_tel"].Value = textBox5.Text;
            sqlCommand1.Parameters["@date_Purchase"].Value = dateTimePicker2.Value;

            // открыть соединение с БД
            sqlConnection1.Open();
            // выполнить sql-выражение (хранимую процедуру) и вернуть количество
            sqlCommand1.ExecuteNonQuery();
            // закрыть соединение с БД
            sqlConnection1.Close();

            var result = sqlCommand1.Parameters["@res"].Value;
            MessageBox.Show(Convert.ToString(result));
        }
    }
}
