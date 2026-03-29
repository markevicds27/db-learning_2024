using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBKozlovskiy
{
    public partial class AddResult : Form
    {

        Connection dataBase = new Connection();

        public int project2;

        public AddResult()
        {
            InitializeComponent();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from control", conn);
            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();
            load.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataBase.openConnection();

                int project = project2;
                int control = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var result = textBox1.Text;

                var addQuery = $"insert into result (idProject, idControl, resultControl) values ('{project}','{control}','{result}')";
                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());
                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
