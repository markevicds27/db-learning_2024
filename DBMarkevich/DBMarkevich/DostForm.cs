using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMarkevich
{
    public partial class DostForm : Form
    {

        DataBase dataBase = new DataBase();

        public DostForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DostForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
            LoadComboBoxFood();
            LoadComboBoxPost();
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getDost = new SqlCommand("select dost.iddost, food.namefood, food.typefood, post.namepost, post.typepost, dost.price, dost.countdost from dost, post, food where dost.idfood = food.idfood and dost.idpost = post.idpost", conn);

            SqlDataAdapter gd = new SqlDataAdapter(getDost);

            DataTable dost = new DataTable();

            gd.Fill(dost);

            dataGridView1.DataSource = dost;
        }

        private void LoadComboBoxFood()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idfood, namefood from food", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxFood.DataSource = cageBox;
            comboBoxFood.DisplayMember = "namefood";
            comboBoxFood.ValueMember = "idfood";
            conn.Close();
        }

        private void LoadComboBoxPost()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idpost, namepost from post", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxPost.DataSource = cageBox;
            comboBoxPost.DisplayMember = "namepost";
            comboBoxPost.ValueMember = "idpost";
            conn.Close();
        }

        private void ClearFields()
        {
            comboBoxPost.Text = "";
            comboBoxFood.Text = "";
            textBoxCount.Text = "";
            textBoxPrice.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxFoodS.Text = "";
            textBoxPostS.Text = "";
            textBoxTypeFoodS.Text = "";
            textBoxTypePostS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            

            int food = int.Parse(comboBoxFood.SelectedValue.ToString());
            int post = int.Parse(comboBoxPost.SelectedValue.ToString());
            var price = textBoxPrice.Text;
            int count;

            if (comboBoxFood.Text != "" && comboBoxPost.Text != "" && textBoxCount.Text != "" && textBoxPrice.Text != "")
            {
                if (int.TryParse(textBoxCount.Text, out count))
                {
                    var addQuery = $"insert into dost (idfood, idpost, price, countdost) values ('{food}','{post}', '{price}', '{count}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    GetData();
                }
                else
                {
                    MessageBox.Show("Введите целое число в графе количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                var delQuery = $"delete from dost where iddost = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
        }

        private void textBoxPostS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namepost like '%{textBoxPostS.Text}%'";
        }

        private void textBoxTypeFoodS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typefood like '%{textBoxTypeFoodS.Text}%'";
        }

        private void textBoxFoodS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namefood like '%{textBoxFoodS.Text}%'";
        }

        private void textBoxTypePostS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typepost like '%{textBoxTypePostS.Text}%'";
        }

    }
}
