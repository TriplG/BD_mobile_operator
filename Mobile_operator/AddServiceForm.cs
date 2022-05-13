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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@tel_old"].Value = textBox1.Text;
            sqlCommand1.Parameters["@tel_old_new"].Value = textBox2.Text;

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
