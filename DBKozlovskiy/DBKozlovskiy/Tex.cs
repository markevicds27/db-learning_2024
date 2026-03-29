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

namespace DBKozlovskiy
{
    public partial class Tex : Form
    {

        Connection dataBase = new Connection();

        public Tex()
        {
            InitializeComponent();
        }

        private void Tex_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from tex", conn);

            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();

            load.Fill(data);

            dataGridViewTex.DataSource = data;
        }

        private void Clear()
        {
            textBoxName.Text = "";
            textBoxChar.Text = "";

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newTex= new NewTex();
                newTex.FormClosed += newTex_FormClosed;
            Hide();
            newTex.ShowDialog();

        }


        private void newTex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxChar.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridViewTex.CurrentRow.Cells[0].Value.ToString());
                var name = textBoxName.Text;
                var ch = textBoxChar.Text;

                var editQuery = $"update tex set nameTex = '{name}', charTex = '{ch}' where idTex = '{id}'";

                var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                editCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int id =  int.Parse(dataGridViewTex.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery1 = $"delete from projectTex where idTex = '{id}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from tex where idTex = '{id}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewTex.DataSource as DataTable).DefaultView.RowFilter = $"charTex like '%{textBox2.Text}%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewTex.DataSource as DataTable).DefaultView.RowFilter = $"nameTex like '%{textBox1.Text}%'";
        }

        private void dataGridViewTex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = dataGridViewTex.CurrentRow.Cells[1].Value.ToString();
            var ch = dataGridViewTex.CurrentRow.Cells[2].Value.ToString();

            textBoxName.Text = name;
            textBoxChar.Text = ch;
        }
    }
}
