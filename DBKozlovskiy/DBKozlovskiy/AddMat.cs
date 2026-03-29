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
    public partial class AddMat : Form
    {

        Connection dataBase = new Connection();

        public int project2;

        public AddMat()
        {
            InitializeComponent();
        }

        private void AddMat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from mat", conn);
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
                int mat = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int count;
                if (int.TryParse(textBox1.Text, out count))
                {

                    var addQuery = $"insert into projectMat (idProject, idMat, countMat) values ('{project}','{mat}','{count}')";
                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());
                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите целое число в поле количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
