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

namespace DBZhuk
{
    public partial class SpmFrom : Form
    {

        Conn dataBase = new Conn();

        public SpmFrom()
        {
            InitializeComponent();
        }

        private void SpmFrom_Load(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = false;            
            Data();
            
        }       

        private void Data()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSor = new SqlCommand("select sportsmanSport.idSportsman, sportsman.sNameSportsman, sportsman.nameSportsman, sportsman.pNameSportsman, sportsman.genderSportsman, sportsman.ageSportsman, sportsmanSport.idSport, sport.nameSport from sportsman, sportsmanSport, sport where sportsmanSport.idSportsman = sportsman.idSportsman and sportsmanSport.idSport = sport.idSport", conn);

            SqlDataAdapter gs = new SqlDataAdapter(getSor);

            DataTable sor = new DataTable();

            gs.Fill(sor);

            dataGridView111.DataSource = sor;
        }      

        private void textBoxSname_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"sNameSportsman like '%{textBoxSname.Text}%'";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"nameSportsman like '%{textBoxName.Text}%'";
        }

        private void textBoxPname_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"pNameSportsman like '%{textBoxPname.Text}%'";
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxGender.SelectedIndex)
            {
                case 0:
                    (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"genderSportsman = 'Мужской'";
                    break;
                case 1:
                    (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"genderSportsman = 'Женский'";
                    break;
                case 2:
                    (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"convert(ageSportsman, 'System.String') like '%{textBoxAge.Text}%'";
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            int sport1 = int.Parse(dataGridView111.CurrentRow.Cells[6].Value.ToString());
            int sportsman1 = int.Parse(dataGridView111.CurrentRow.Cells[0].Value.ToString());


            var sportsmanTrener = new SportsmanTrenerForm();
            sportsmanTrener.FormClosed += sportsmanTrener_FormClosed;
            sportsmanTrener.sport2 = sport1;
            sportsmanTrener.sportsman2 = sportsman1;
            Hide();
            sportsmanTrener.ShowDialog();
        }

        private void sportsmanTrener_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            var addSportsmanForm = new AddSportsmanForm();
            addSportsmanForm.FormClosed += addSportsmanForm_FormClosed;
            Hide();
            addSportsmanForm.ShowDialog();
        }

        private void addSportsmanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }

        static public string idNum;

        private void button4_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = true;

            idNum = dataGridView111.CurrentRow.Cells[0].Value.ToString();
            var surname = dataGridView111   .CurrentRow.Cells[1].Value.ToString();
            var name = dataGridView111.CurrentRow.Cells[2].Value.ToString();
            var patron = dataGridView111.CurrentRow.Cells[3].Value.ToString();
            var age = dataGridView111.CurrentRow.Cells[4].Value.ToString();
            var gender = dataGridView111.CurrentRow.Cells[5].Value.ToString();
            
            textBoxSurnameE.Text = surname;
            textBoxNameE.Text = name;
            textBoxPatronE.Text = patron;
            textBoxAgeE.Text = age;
            comboBoxGenderE.Text = gender;
        }

        private void ClearE()
        {
            textBoxNameE.Text = "";
            textBoxPatronE.Text = "";
            textBoxAgeE.Text = "";
            textBoxSurnameE.Text = "";
            comboBoxGenderE.Text = "";
        }

        private void buttonEditYes_Click(object sender, EventArgs e)
        {
            

            if (textBoxNameE.Text != "" && textBoxSurnameE.Text != "" && comboBoxGenderE.Text != "" && textBoxAgeE.Text != "" && textBoxPatronE.Text != "")
            {
                dataBase.openConnection();

                var surnameE = textBoxSurnameE.Text;
                var nameE = textBoxNameE.Text;
                var patronE = textBoxPatronE.Text;
                int ageE;
                var genderE = comboBoxGenderE.Text;
                if (int.TryParse(textBoxAgeE.Text, out ageE))
                {
                    var editQuery = $"update sportsman set sNameSportsman = '{surnameE}', nameSportsman = '{nameE}', pNameSportsman = '{patronE}', ageSportsman = '{ageE}', genderSportsman = '{genderE}' where idSportsman = '{idNum}'";

                    var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                    editCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Data();
                    ClearE();
                    groupBoxEdit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Введите целое число в возрасте", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public string idDel;
        static public string idSport111;

        private void button3_Click(object sender, EventArgs e)
        {
            idDel = dataGridView111.CurrentRow.Cells[0].Value.ToString();
            idSport111 = dataGridView111.CurrentRow.Cells[6].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delQuery1 = $"delete from sportsmanSport where idSportsman = '{idDel}' and idSport = '{idSport111}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery2 = $"delete from sportsmanTrener where idSportsman = '{idDel}'";
                var delCommand2 = new SqlCommand(delQuery2, dataBase.getConnection());
                delCommand2.ExecuteNonQuery();
                var delQuery3 = $"delete from sorevnovanieSportsman where idSportsman = '{idDel}'";
                var delCommand3 = new SqlCommand(delQuery3, dataBase.getConnection());
                delCommand3.ExecuteNonQuery();
                var delQuery = $"delete from sportsman where idSportsman = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"nameSport like '%{textBox1.Text}%'";
        }

        private void buttonEditNo_Click(object sender, EventArgs e)
        {
            ClearE();
            groupBoxEdit.Visible = false;
        }

    }
}
