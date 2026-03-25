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
    public partial class MedForm : Form
    {

        DataBase dataBase = new DataBase();

        public MedForm()
        {
            InitializeComponent();
        }

        private void MedForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();            
            ClearFieldsS();
            LoadComboBoxWorker();
            LoadComboBoxAnimal();             
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getMed = new SqlCommand("select med.idmed, worker.surnameworker, worker.nameworker, worker.oldnameworker, animal.idanimal, animal.nameanimal, med.datemed, med.result from animal, med, worker where med.idworker = worker.idworker and med.idanimal = animal.idanimal", conn);

            SqlDataAdapter gm = new SqlDataAdapter(getMed);

            DataTable med = new DataTable();

            gm.Fill(med);

            dataGridView1.DataSource = med;
        }

        private void LoadComboBoxWorker()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idworker, surnameworker from worker where status = 4", conn);
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
        }        

        private void ClearFieldsS()
        {
            textBoxNameAnimalS.Text = "";           
            textBoxSurnameS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            int worker = int.Parse(comboBoxWorker.SelectedValue.ToString());
            int animal = int.Parse(comboBoxAnimal.SelectedValue.ToString());
            DateTime date = dateTimePicker1.Value;
            var result = textBoxResult.Text;

            if (comboBoxAnimal.Text != "" && comboBoxWorker.Text != "" && dateTimePicker1.Value != null && textBoxResult.Text != "")
            {
                var addQuery = $"insert into med (idworker, idanimal, datemed, result) values ('{worker}','{animal}', '{date}', '{result}')";

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
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from med where idmed = '{idDel}'";
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

        private void textBoxNameAnimalS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameanimal like '%{textBoxNameAnimalS.Text}%'";
        }

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            GetData();
            ClearFieldsS();
            LoadComboBoxAnimal();
                LoadComboBoxWorker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var priv= new PrivivkiForm();
                priv.FormClosed += priv_FormClosed;
            Hide();
                priv.ShowDialog();

        }

        private void priv_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxAnimal();
            LoadComboBoxWorker();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            var karta= new KartaForm();
                karta.FormClosed += karta_FormClosed;
            Hide();
                karta.ShowDialog();

        }

        private void karta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxAnimal();
            LoadComboBoxWorker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var doza= new DozaForm();
                doza.FormClosed += doza_FormClosed;
            Hide();
                doza.ShowDialog();


        }

        private void doza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxWorker();
            LoadComboBoxAnimal();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var bol= new BoleznForm();
                bol.FormClosed += bol_FormClosed;
            Hide();
                bol.ShowDialog();

        }

        private void bol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxAnimal();
                LoadComboBoxWorker();
        }
    }
}
