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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBKozlovskiy
{
    public partial class Worker : Form
    {

        Connection dataBase = new Connection();

        public Worker()
        {
            InitializeComponent();
        }

        
        private void Worker_Load(object sender, EventArgs e)
        {
            LoadData();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            ComboBoxDol();
            ComboBoxOtdel();
        }

        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select worker.idWorker, worker.surnameWorker, worker.nameWorker, worker.patronWorker, worker.ageWorker, worker.stazWorker, dolzhnost.nameDolznost, otdel.nameOtdel from worker, dolzhnost, status, otdel where status.idWorker = worker.idWorker and status.idDolzhnost = dolzhnost.idDolzhnost and status.idOtdel = otdel.idOtdel", conn);

            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();

            load.Fill(data);

            dataGridView1.DataSource = data;
        }

        private void Clear()
        {
            textBoxSurname.Text = "";
            textBoxName.Text = "";
            textBoxPatron.Text = "";
            textBoxAge.Text = "";
            textBoxStaz.Text = "";
        }

        private void ComboBoxDol()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idDolzhnost, nameDolznost from dolzhnost", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable box = new DataTable();
            sqlDataAdapter.Fill(box);
            comboBoxDol.DataSource = box;
            comboBoxDol.DisplayMember = "nameDolznost";
            comboBoxDol.ValueMember = "idDolzhnost";
            conn.Close();
        }


        private void ComboBoxOtdel()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBoxO = new SqlCommand("select idOtdel, nameOtdel from otdel", conn);
            SqlDataAdapter sqlDataAdapterO = new SqlDataAdapter(loadBoxO);
            sqlDataAdapterO.SelectCommand = loadBoxO;
            DataTable boxO = new DataTable();
            sqlDataAdapterO.Fill(boxO);
            comboBoxOtdel.DataSource = boxO;
            comboBoxOtdel.DisplayMember = "nameOtdel";
            comboBoxOtdel.ValueMember = "idOtdel";
            conn.Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newWorker= new NewWorker();
                newWorker.FormClosed += newWorker_FormClosed;
            Hide();
            newWorker.ShowDialog();
            
        }

        private void newWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text != "" && textBoxStaz.Text != "" && textBoxPatron.Text != "" && textBoxName.Text != "" && textBoxAge.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var surname = textBoxSurname.Text;
                var name = textBoxName.Text;
                var patron = textBoxPatron.Text;
                int age;
                int staz;

                if (int.TryParse(textBoxAge.Text, out age))
                {
                    if (int.TryParse(textBoxStaz.Text, out staz))
                    {
                        var editQuery = $"update worker set surnameWorker = '{surname}', nameWorker = '{name}', patronWorker = '{patron}', ageWorker = '{age}', stazWorker = '{staz}' where idWorker = '{id}'";

                        var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                        editCommand.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число в поле стаж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите целое число в поле возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            var dol = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxDol.Text = dol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            var otdel = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxOtdel.Text = otdel;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int idDelete = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery2 = $"delete from status where idWorker = '{idDelete}'";
                var delCommand2 = new SqlCommand(delQuery2, dataBase.getConnection());
                delCommand2.ExecuteNonQuery();
                var delQuery1 = $"delete from workingWorker where idWorker = '{idDelete}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from worker where idWorker = '{idDelete}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var patron = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var age = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            var staz = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            textBoxSurname.Text = surname;
            textBoxName.Text = name;
            textBoxPatron.Text = patron;
            textBoxAge.Text = age;
            textBoxStaz.Text = staz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            int dol = int.Parse(comboBoxDol.SelectedValue.ToString());

            var editQuery = $"update status set idDolzhnost = '{dol}' where idWorker = '{id}'";

            var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

            editCommand.ExecuteNonQuery();

            MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            Clear();
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            int otdel = int.Parse(comboBoxOtdel.SelectedValue.ToString());

            var editQuery = $"update status set idOtdel = '{otdel}' where idWorker = '{id}'";

            var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

            editCommand.ExecuteNonQuery();

            MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            Clear();
            groupBox2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"surnameWorker like '%{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameWorker like '%{textBox2.Text}%'";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"patronWorker like '%{textBox3.Text}%'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(ageWorker, 'System.String') like '%{textBox4.Text}%'";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(stazWorker, 'System.String') like '%{textBox5.Text}%'";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameDolznost like '%{textBox6.Text}%'";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameOtdel like '%{textBox7.Text}%'";
        }
    }
}
