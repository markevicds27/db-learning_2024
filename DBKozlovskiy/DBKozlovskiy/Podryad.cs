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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBKozlovskiy
{
    public partial class Podryad : Form
    {

        Connection dataBase = new Connection();

        public Podryad()
        {
            InitializeComponent();
        }

        private void Podryad_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select * from podryad", conn);

            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();

            load.Fill(data);

            dataGridView1.DataSource = data;
        }

        private void Clear()
        {
            textBoxName.Text = "";
            textBoxFace.Text = "";
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newPodryad= new NewPodryad();
            newPodryad.FormClosed += newPodryad_FormClosed;
            Hide();
            newPodryad.ShowDialog();
            
        }

        private void newPodryad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxFace.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var name = textBoxName.Text;
                var face = textBoxFace.Text;

                var editQuery = $"update podryad set namePodryad = '{name}', facePodryad = '{face}' where idPodryad = '{id}'";

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
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                dataBase.openConnection();
                var delQuery1 = $"delete from workingPodryad where idPodryad = '{id}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from podryad where idPodryad = '{id}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var face = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            textBoxName.Text = name;
            textBoxFace.Text = face;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namePodryad like '%{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"facePodryad like '%{textBox2.Text}%'";
        }
    }
}
