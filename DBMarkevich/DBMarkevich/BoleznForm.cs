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
    public partial class BoleznForm : Form
    {

        DataBase dataBase = new DataBase();

        public BoleznForm()
        {
            InitializeComponent();
        }

        private void BoleznForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
          
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getBolezn = new SqlCommand("select * from bolezn", conn);

            SqlDataAdapter gb = new SqlDataAdapter(getBolezn);

            DataTable bolezn = new DataTable();

            gb.Fill(bolezn);

            dataGridView1.DataSource = bolezn;
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxSimptom.Text = "";
            textBoxLech.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxNameS.Text = "";
            textBoxSimptomS.Text = "";          
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBoxName.Text;
            var simptom = textBoxSimptom.Text;
            var lech = textBoxLech.Text;

            if (textBoxName.Text != "" && textBoxSimptom.Text != "" && textBoxLech.Text != "")
            {
                var addQuery = $"insert into bolezn (namebolezn, simptom, lechenie) values ('{name}','{simptom}', '{lech}')";

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

        static public string idDel;

        private void buttonAddNo_Click(object sender, EventArgs e)
        {
            ClearFields();
        }        

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
        }

        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namebolezn like '%{textBoxNameS.Text}%'";
        }

        private void textBoxSimptomS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"simptom like '%{textBoxSimptomS.Text}%'";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery1 = $"delete from karta where idbolezn = '{idDel}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();

                var delQuery2 = $"delete from privivka where idbolezn = '{idDel}'";
                var delCommand2 = new SqlCommand(delQuery2, dataBase.getConnection());
                delCommand2.ExecuteNonQuery();

                var delQuery3 = $"delete from bolezn where idbolezn = '{idDel}'";
                var delCommand3 = new SqlCommand(delQuery3, dataBase.getConnection());
                delCommand3.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

    }
}
