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
    public partial class orderSCardForm : Form
    {
        public orderSCardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand2.Parameters["@tel"].Value = textBox1.Text;
            sqlCommand2.Parameters["@id_tariff"].Value =
Convert.ToInt32(textBox2.Text);
            // открыть соединение с БД
            sqlConnection1.Open();
            // выполнить sql-выражение (хранимую процедуру) и вернуть количество
            sqlCommand2.ExecuteNonQuery();
            // закрыть соединение с БД
            sqlConnection1.Close();

            var result = sqlCommand2.Parameters["@res"].Value;
            MessageBox.Show(Convert.ToString(result));
        }

        private void orderSCardForm_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            // создать временную таблицу temp
            var temp = new DataTable();
            // выполнить табличную функцию и вернуть таблицу в объект Reader
            // заполнить таблицу temp данными из Reader
            temp.Load(sqlCommand1.ExecuteReader());
            //устанавить связь с объектом типа dataGridView
            dataGridView1.DataSource = temp;
            // закрыть соединение с БД
            sqlConnection1.Close();
            sqlConnection1.Open();
            // создать временную таблицу temp
            var temp1 = new DataTable();
            // выполнить табличную функцию и вернуть таблицу в объект Reader
            // заполнить таблицу temp данными из Reader
            temp1.Load(sqlCommand3.ExecuteReader());
            //устанавить связь с объектом типа dataGridView
            dataGridView2.DataSource = temp1;
            // закрыть соединение с БД
            sqlConnection1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new SwipeTariffForm();
            frm.Show();
        }
    }
}
