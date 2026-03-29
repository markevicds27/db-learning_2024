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

namespace DBMarkevich
{
    public partial class CageForm : Form
    {

        DataBase dataBase = new DataBase();

        public CageForm()
        {
            InitializeComponent();
        }

        private void CageForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getCage = new SqlCommand("select * from cage", conn);

            SqlDataAdapter gc = new SqlDataAdapter(getCage);

            DataTable cage = new DataTable();

            gc.Fill(cage);

            dataGridView1.DataSource = cage;
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            comboBoxType.Text = "";
            textBoxNature.Text = "";
            textBoxSeason.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxTypeS.Text = "";
            textBoxNature.Text = "";
            textBoxSeason.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBoxName.Text;
            var type = comboBoxType.Text;
            var nature = textBoxNature.Text;
            var season = textBoxSeason.Text;
            
            if (textBoxName.Text != "" && comboBoxType.Text != "" && textBoxNature.Text != "" && textBoxSeason.Text != "")
            {
                var addQuery = $"insert into cage (namecage, typecage, nature, season) values ('{name}','{type}', '{nature}', '{season}')";

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
            GetData();
        }

        private void textBoxSeasonS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"season like '%{textBoxSeasonS.Text}%'";
        }

        private void textBoxNatureS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nature like '%{textBoxNatureS.Text}%'";
        }

        private void textBoxTypeS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typecage like '%{textBoxTypeS.Text}%'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var clean= new CleanForm();
                clean.FormClosed += clean_FormClosed;
            Hide();
                clean.ShowDialog();

        }

        private void clean_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

    }
}
