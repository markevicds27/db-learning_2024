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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBMarkevich
{
    public partial class ZakrepForm : Form
    {

        DataBase dataBase = new DataBase();

        public ZakrepForm()
        {
            InitializeComponent();
        }

        private void ZakrepForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();            
            ClearFieldsS();
            LoadComboBoxWorker();
            LoadComboBoxAnimal();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getZakrep = new SqlCommand("select zakrep.idzakrep, worker.surnameworker as 'Фамилия', worker.nameworker as 'Имя', worker.oldnameworker as 'Отчество', animal.nameanimal as 'Название животного', animal.typeanimal as 'Вид животного', zakrep.date as 'Дата закрепления' from animal, zakrep, worker where zakrep.idworker = worker.idworker and zakrep.idanimal = animal.idanimal", conn);

            SqlDataAdapter gz = new SqlDataAdapter(getZakrep);

            DataTable zakrep = new DataTable();

            gz.Fill(zakrep);

            dataGridView1.DataSource = zakrep;
        }

        private void LoadComboBoxWorker()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idworker, surnameworker from worker", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxWorker.DataSource = cageBox;
            comboBoxWorker.DisplayMember = "surnameworker";
            comboBoxWorker.ValueMember = "idworker";           
            conn.Close();
        }

        private void LoadComboBoxAnimal()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idanimal, nameanimal from animal", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxAnimal.DataSource = cageBox;
            comboBoxAnimal.DisplayMember = "nameanimal";
            comboBoxAnimal.ValueMember = "idanimal";           
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
            textBoxNameAnimalS.Text = "";
            textBoxNameS.Text = "";
            textBoxVidS.Text = "";
            textBoxSurnameS.Text = "";
        }

        

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            int worker = int.Parse(comboBoxWorker.SelectedValue.ToString());            
            int animal = int.Parse(comboBoxAnimal.SelectedValue.ToString());
            DateTime date = dateTimePicker1.Value;

            if (comboBoxAnimal.Text != "" && comboBoxWorker.Text != "" && dateTimePicker1.Value != null)
            {
                var addQuery = $"insert into zakrep (idworker, idanimal, date) values ('{worker}','{animal}', '{date}')";

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
                var delQuery = $"delete from zakrep where idzakrep = '{idDel}'";
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

        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameworker like '%{textBoxNameS.Text}%'";
        }

        private void textBoxNameAnimalS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameanimal like '%{textBoxNameAnimalS.Text}%'";
        }

        private void textBoxVidS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typeanimal like '%{textBoxVidS.Text}%'";
        }

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {            
            ClearFieldsS();
            GetData();
        }  


        
    }
}
