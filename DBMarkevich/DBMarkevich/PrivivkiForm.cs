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
    public partial class PrivivkiForm : Form
    {

        DataBase dataBase = new DataBase();

        public PrivivkiForm()
        {
            InitializeComponent();
        }

        private void PrivivkiForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();         
            LoadComboBoxBolezn();
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getPrivivka = new SqlCommand("select privivka.idprivivka, privivka.nameprivivka, bolezn.namebolezn, privivka.doza from bolezn, privivka where privivka.idbolezn = bolezn.idbolezn", conn);

            SqlDataAdapter gp = new SqlDataAdapter(getPrivivka);

            DataTable privivka = new DataTable();

            gp.Fill(privivka);

            dataGridView1.DataSource = privivka;
        }

        private void LoadComboBoxBolezn()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idbolezn, namebolezn from bolezn", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBox1.DataSource = cageBox;
            comboBox1.DisplayMember = "namebolezn";
            comboBox1.ValueMember = "idbolezn";
            
            conn.Close();
        }


        private void ClearFields()
        {
            textBoxName.Text = "";
            comboBox1.Text = "";
            textBoxDoza.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxNameS.Text = "";
            textBoxBoleznS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBoxName.Text;
            int bolezn = int.Parse(comboBox1.SelectedValue.ToString());
            var doza = textBoxDoza.Text;

            if (textBoxName.Text != "" && textBoxDoza.Text != "" && comboBox1.Text != "")
            {
                var addQuery = $"insert into privivka (nameprivivka, idbolezn, doza) values ('{name}','{bolezn}','{doza}')";

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
            GetData();
            ClearFieldsS();
        }

        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameprivivka like '%{textBoxNameS.Text}%'";
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
                var delQuery1 = $"delete from doza where idprivivka = '{idDel}'";
                var delCommand1= new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from privivka where idprivivka = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

        
    }
}
