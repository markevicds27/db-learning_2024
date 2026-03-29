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
using System.Xml.Linq;

namespace DBKozlovskiy
{
    public partial class Dogovora : Form
    {

        Connection dataBase = new Connection();

        public Dogovora()
        {
            InitializeComponent();
        }

        private void Dogovora_Load(object sender, EventArgs e)
        {
            LoadData();
            groupBox1.Visible = false;
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();
            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select dogovor.idDogovor, dogovor.nameDogovor, zakaz.nameZakaz, dogovor.statusDogovor, dogovor.dateStartDogovor, dogovor.dateFibishDogovor from dogovor, zakaz where dogovor.idZakaz = zakaz.idZakaz", conn);
            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();
            load.Fill(data);
            dataGridView1.DataSource = data;
        }       

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (del == DialogResult.Yes)
            {
                dataBase.openConnection();

                var delQuery = $"delete from project where idDogovor = '{id}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                var delQuery1 = $"delete from dogovor where idDogovor = '{id}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();

                MessageBox.Show("Запись удалена");

                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
              

        private void button1_Click(object sender, EventArgs e)
        {
            int dogovor1 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());   
            
            var project= new Project();

            project.FormClosed += project_FormClosed;
            project.dogovor2 = dogovor1;
            Hide();
            project.ShowDialog();            
        }

        private void project_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var status = comboBox1.Text;

                var editQuery = $"update dogovor set statusDogovor = '{status}' where idDogovor = '{id}'";
                var editCommand = new SqlCommand(editQuery, dataBase.getConnection());
                editCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Выберите статус", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
