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
    public partial class DozaForm : Form
    {

        DataBase dataBase = new DataBase();

        public DozaForm()
        {
            InitializeComponent();
        }

        private void buttonAddNo_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DozaForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();         
            ClearFieldsS();
            LoadComboBoxAnimal();
            LoadComboBoxPrivivka();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getDoza = new SqlCommand("select doza.iddoza, animal.nameanimal as 'Животное', privivka.nameprivivka as 'Прививка', doza.date as 'Дата прививания' from animal, doza, privivka where doza.idanimal = animal.idanimal and doza.idprivivka = privivka.idprivivka", conn);

            SqlDataAdapter gd = new SqlDataAdapter(getDoza);

            DataTable doza = new DataTable();

            gd.Fill(doza);

            dataGridView1.DataSource = doza;
        }

        private void LoadComboBoxPrivivka()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idprivivka, nameprivivka from privivka", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxPrivivka.DataSource = cageBox;
            comboBoxPrivivka.DisplayMember = "nameprivivka";
            comboBoxPrivivka.ValueMember = "idprivivka";          
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
            comboBoxPrivivka.Text = "";
        }      

        private void ClearFieldsS()
        {
            textBoxPrivivkaS.Text = "";            
            textBoxPrivivkaS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            int privivka = int.Parse(comboBoxPrivivka.SelectedValue.ToString());
            int animal = int.Parse(comboBoxAnimal.SelectedValue.ToString());
            DateTime date = dateTimePicker1.Value;

            if (comboBoxAnimal.Text != "" && comboBoxPrivivka.Text != "" && dateTimePicker1.Value != null)
            {
                var addQuery = $"insert into doza (idanimal, idprivivka, date) values ('{animal}','{privivka}', '{date}')";

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

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
        }

        private void textBoxAnimalS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameanimal like '%{textBoxAnimalS.Text}%'";
        }

        private void textBoxPrivivkaS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameprivivka like '%{textBoxPrivivkaS.Text}%'";
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                dataBase.openConnection();
                var delQuery = $"delete from doza where iddoza = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

    }
}
