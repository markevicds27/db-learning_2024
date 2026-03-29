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
    public partial class PostForm : Form
    {

        DataBase dataBase = new DataBase();

        public PostForm()
        {
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getPost = new SqlCommand("select * from post", conn);

            SqlDataAdapter gp = new SqlDataAdapter(getPost);

            DataTable post = new DataTable();

            gp.Fill(post);

            dataGridView1.DataSource = post;
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            comboBoxDost.Text = "";
            comboBoxType.Text = "";
            textBoxSrok.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxNameS.Text = "";
            textBoxTypeS.Text = "";
            textBoxSrok.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBoxName.Text;
            var type = comboBoxType.Text;
            var dost = comboBoxDost.Text;
            int srok;

            if (comboBoxDost.Text != "" && comboBoxType.Text != "" && textBoxName.Text != "" && textBoxSrok.Text != "")
            {
                if (int.TryParse(textBoxSrok.Text, out srok))
                {

                    var addQuery = $"insert into post (namepost, typepost, dostavka, srok) values ('{name}','{type}', '{dost}', '{srok}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    GetData();
                }
                else
                {
                    MessageBox.Show("Введите целое число в графе срок выполнения заказа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var delQuery1 = $"delete from dost where idpost = '{idDel}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from post where idpost = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namepost like '%{textBoxNameS.Text}%'";
        }

        private void textBoxDostS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"dostavka '%{textBoxDostS.Text}%'";
        }

        private void textBoxTypeS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typepost like '%{textBoxTypeS.Text}%'";
        }

        
    }
}
