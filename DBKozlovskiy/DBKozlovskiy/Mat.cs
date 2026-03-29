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
    public partial class Mat : Form
    {

        Connection dataBase = new Connection();

        public Mat()
        {
            InitializeComponent();
        }

        private void Mat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from mat", conn);
            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();
            load.Fill(data);
            dataGridViewMat.DataSource = data;
        }

        private void Clear()
        {
            textBoxName.Text = "";
            textBoxChar.Text = "";

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxChar.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridViewMat.CurrentRow.Cells[0].Value.ToString());
                var name = textBoxName.Text;
                var ch = textBoxChar.Text;

                var editQuery = $"update mat set nameMat = '{name}', charMat = '{ch}' where idMat = '{id}'";
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newMat = new NewMat();
            newMat.FormClosed += newMat_FormClosed;
            Hide();
            newMat.ShowDialog();

        }


        private void newMat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }
        
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewMat.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                dataBase.openConnection();
                var delQuery1 = $"delete from projectMat where idMat = '{id}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from mat where idMat = '{id}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewMat.DataSource as DataTable).DefaultView.RowFilter = $"nameMat like '%{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewMat.DataSource as DataTable).DefaultView.RowFilter = $"nameMat like '%{textBox2.Text}%'";
        }

        private void dataGridViewMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = dataGridViewMat.CurrentRow.Cells[1].Value.ToString();
            var ch = dataGridViewMat.CurrentRow.Cells[2].Value.ToString();

            textBoxName.Text = name;
            textBoxChar.Text = ch;
        }
    }
}
