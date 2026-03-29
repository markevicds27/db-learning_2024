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

namespace DBMarkevich
{
    public partial class CleanForm : Form
    {

        DataBase dataBase = new DataBase();

        public CleanForm()
        {
            InitializeComponent();
        }

        private void CleanForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
            LoadComboBoxWorker();
            LoadComboBoxCage();
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getClean = new SqlCommand("select clean.idclean, clean.idworker, worker.surnameworker, worker.nameworker, worker.oldnameworker, clean.idcage, clean.date from clean, worker where clean.idworker = worker.idworker", conn);

            SqlDataAdapter gc = new SqlDataAdapter(getClean);

            DataTable clean = new DataTable();

            gc.Fill(clean);

            dataGridView1.DataSource = clean;
        }

        private void LoadComboBoxWorker()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idworker, surnameworker from worker where status = 5", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxWorker.DataSource = cageBox;
            comboBoxWorker.DisplayMember = "surnameworker";
            comboBoxWorker.ValueMember = "idworker";
            conn.Close();
        }

        private void LoadComboBoxCage()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idcage from cage", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxAnimal.DataSource = cageBox;
            comboBoxAnimal.DisplayMember = "idcage";
            comboBoxAnimal.ValueMember = "idcage";
            conn.Close();
        }

        private void ClearFields()
        {
            comboBoxAnimal.Text = "";
            comboBoxWorker.Text = "";
            dateTimePicker1.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxSurnameS.Text = "";
            textBoxCageS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            int worker = int.Parse(comboBoxWorker.SelectedValue.ToString());
            int cage = int.Parse(comboBoxAnimal.SelectedValue.ToString());
            DateTime date = dateTimePicker1.Value;

            if (comboBoxAnimal.Text != "" && comboBoxWorker.Text != "" && dateTimePicker1.Value != null)
            {
                var addQuery = $"insert into clean (idworker, idcage, date) values ('{worker}','{cage}', '{date}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GetData();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddNo_Click(object sender, EventArgs e)
        {
            ClearFields();
            GetData();
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                dataBase.openConnection();
                var delQuery = $"delete from clean where idclean = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

        private void textBoxSurnameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"surnameworker like '%{textBoxSurnameS.Text}%'";
        }

        private void textBoxCageS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(idcage, 'System.String') like '%{textBoxCageS.Text}%'";
        }

        
    }
}
