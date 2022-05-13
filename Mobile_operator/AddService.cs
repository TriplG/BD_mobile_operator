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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@info"].Value = textBox1.Text;
            sqlCommand1.Parameters["@date"].Value = textBox2.Text;
            sqlCommand1.Parameters["@price"].Value = Convert.ToInt32(textBox3.Text);



            // открыть соединение с БД
            sqlConnection1.Open();
            // выполнить sql-выражение (хранимую процедуру) и вернуть количество
            sqlCommand1.ExecuteNonQuery();
            // закрыть соединение с БД
            sqlConnection1.Close();

            var result = sqlCommand1.Parameters["@res"].Value;
            MessageBox.Show(Convert.ToString(result));
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            // создать временную таблицу temp
            var temp = new DataTable();
            // выполнить табличную функцию и вернуть таблицу в объект Reader
            // заполнить таблицу temp данными из Reader
            temp.Load(sqlCommand2.ExecuteReader());
            //устанавить связь с объектом типа dataGridView
            dataGridView1.DataSource = temp;
            // закрыть соединение с БД
            sqlConnection1.Close();
        }
    }
}
