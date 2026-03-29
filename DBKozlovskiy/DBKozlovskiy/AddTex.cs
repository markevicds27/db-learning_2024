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
    public partial class AddTex : Form
    {

        Connection dataBase = new Connection();

        public int project2;

        public AddTex()
        {
            InitializeComponent();
        }

        private void AddTex_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from tex", conn);
            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();
            load.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null)
            {
                dataBase.openConnection();

                int project = project2;
                int tex = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                DateTime dateTime = dateTimePicker1.Value;

                var addQuery = $"insert into projectTex (idProject, idTex, dateWork) values ('{project}','{tex}','{dateTime}')";
                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());
                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите дату эксплуатации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
