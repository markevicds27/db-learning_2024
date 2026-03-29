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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBKozlovskiy
{
    public partial class AddWorker : Form
    {

        Connection dataBase = new Connection();

        public int project2;

        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {            
            LoadData();
        }   

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select worker.idWorker, worker.surnameWorker, worker.nameWorker, worker.patronWorker, worker.ageWorker, worker.stazWorker, dolzhnost.nameDolznost, otdel.nameOtdel from worker, dolzhnost, otdel, status where status.idWorker = worker.idWorker and status.idDolzhnost = dolzhnost.idDolzhnost and status.idOtdel = otdel.idOtdel", conn);
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

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int project = project2;
                var working = textBox1.Text;

                var addQuery = $"insert into workingWorker (idProject, idWorker, nameWorkingWorker) values ('{project}','{id}','{working}')";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameDolznost like '%{textBox2.Text}%'";
        }
    }
}
