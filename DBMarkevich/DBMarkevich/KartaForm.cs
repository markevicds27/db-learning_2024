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
    public partial class KartaForm : Form
    {

        DataBase dataBase = new DataBase();

        public KartaForm()
        {
            InitializeComponent();
        }

        private void KartaForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
            LoadComboBoxAnimal();
            LoadComboBoxBolezn();            
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getKarta = new SqlCommand("select karta.idkarta, animal.idanimal, animal.nameanimal, bolezn.namebolezn, karta.date, karta.naznachenie from animal, bolezn, karta where karta.idanimal = animal.idanimal and karta.idbolezn = bolezn.idbolezn", conn);

            SqlDataAdapter gk = new SqlDataAdapter(getKarta);

            DataTable karta = new DataTable();

            gk.Fill(karta);

            dataGridView1.DataSource = karta;
        }

        private void LoadComboBoxBolezn()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idbolezn, namebolezn from bolezn", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxBolezn.DataSource = cageBox;
            comboBoxBolezn.DisplayMember = "namebolezn";
            comboBoxBolezn.ValueMember = "idbolezn";
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
            comboBoxBolezn.Text = "";
            textBoxNaznachenie.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxAnimalS.Text = "";
            textBoxBoleznS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {          
            
            dataBase.openConnection();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            int bolezn = int.Parse(comboBoxBolezn.SelectedValue.ToString());
            int animal = int.Parse(comboBoxAnimal.SelectedValue.ToString());
            DateTime date = dateTimePicker1.Value;
            var naznachenie = textBoxNaznachenie.Text;

            if (comboBoxAnimal.Text != "" && comboBoxBolezn.Text != "" && dateTimePicker1.Value != null && textBoxNaznachenie.Text != "")
            {
                var addQuery = $"insert into karta (idanimal, idbolezn, date, naznachenie) values ('{animal}','{bolezn}', '{date}', '{naznachenie}')";

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

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
        }

        private void textBoxAnimalS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameanimal like '%{textBoxAnimalS.Text}%'";
        }

        private void textBoxBoleznS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namebolezn like '%{textBoxBoleznS.Text}%'";
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from karta where idkarta = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

    }
}
