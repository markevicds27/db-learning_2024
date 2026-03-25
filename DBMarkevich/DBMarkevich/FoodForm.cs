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

namespace DBMarkevich
{
    public partial class FoodForm : Form
    {

        DataBase dataBase = new DataBase();

        public FoodForm()
        {
            InitializeComponent();
            
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();                       
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getFood = new SqlCommand("select * from food", conn);

            SqlDataAdapter gf = new SqlDataAdapter(getFood);

            DataTable food = new DataTable();

            gf.Fill(food);

            dataGridView1.DataSource = food;
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxChar.Text = "";
            comboBoxType.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxNameS.Text = "";
            textBoxTypeS.Text = "";            
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var type = comboBoxType.Text;
            var op = textBoxChar.Text;
            

            if (textBoxName.Text != "" && textBoxChar.Text != "" && comboBoxType.Text != "")
            {
                var addQuery = $"insert into food (namefood, typefood, charfood) values ('{name}','{type}', '{op}')";

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

        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namefood like '%{textBoxNameS.Text}%'";
        }

        private void textBoxTypeS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typefood like '%{textBoxTypeS.Text}%'";
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery1 = $"delete from dost where idfood = '{idDel}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery2 = $"delete from eat where idfood = '{idDel}'";
                var delCommand2 = new SqlCommand(delQuery2, dataBase.getConnection());
                delCommand2.ExecuteNonQuery();
                var delQuery = $"delete from food where idfood = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

    }
}
