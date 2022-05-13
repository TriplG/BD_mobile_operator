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
    public partial class WorkerCountForm : Form
    {
        public WorkerCountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand.Parameters["@FIO"].Value = textBox1.Text;

// открыть соединение с БД
mySqlConnection.Open();
            // создать временную таблицу temp
            var temp = new DataTable();
            // выполнить табличную функцию и вернуть таблицу в объект Reader
            // заполнить таблицу temp данными из Reader
            temp.Load(myCommand.ExecuteReader());
            //устанавить связь с объектом типа dataGridView
            dataGridView1.DataSource = temp;
            // закрыть соединение с БД
            mySqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkerCountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
