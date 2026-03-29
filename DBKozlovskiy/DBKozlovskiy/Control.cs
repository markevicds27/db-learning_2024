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
    public partial class Control : Form
    {

        Connection dataBase = new Connection();

        public Control()
        {
            InitializeComponent();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from control", conn);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxChar.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridViewTex.CurrentRow.Cells[0].Value.ToString());
                var name = textBoxName.Text;
                var ch = textBoxChar.Text;

                var editQuery = $"update control set nameControl = '{name}', opisanieControl = '{ch}' where idControl = '{id}'";
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
            var newControl = new NewControl();
            newControl.FormClosed += newControl_FormClosed;
            Hide();
            newControl.ShowDialog();
        }

        private void newControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewTex.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                dataBase.openConnection();

                var delQuery = $"delete from result where idControl = '{id}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                var delQuery1 = $"delete from control where idControl = '{id}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();

                MessageBox.Show("Запись удалена");

                LoadData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewTex.DataSource as DataTable).DefaultView.RowFilter = $"nameControl like '%{textBox1.Text}%'";
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
