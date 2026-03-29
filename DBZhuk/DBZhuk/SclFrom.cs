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

namespace DBZhuk
{
    public partial class SclFrom : Form
    {

        Conn dataBase = new Conn();

        public SclFrom()
        {
            InitializeComponent();
        }

        private void SclFrom_Load(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = false;
            Data();
            
        }

        

        private void Data()
        {           

            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getScl = new SqlCommand("select sportclub.idSportclub, sportclub.nameSportclub, sportclub.citySportcub, sportclub.sportSportclub ,sport.nameSport from sportclub, sport where sportclub.sportSportclub = sport.idSport", conn);       

            SqlDataAdapter gs = new SqlDataAdapter(getScl);

            DataTable scl = new DataTable();

            gs.Fill(scl);

            dataGridView111.DataSource = scl;
        }

        static public string idNum1;
        static public string idSport1;

        private void button1_Click(object sender, EventArgs e)
        {
            idNum1 = dataGridView111.CurrentRow.Cells[0].Value.ToString();
            idSport1 = dataGridView111.CurrentRow.Cells[3].Value.ToString();
            var sportclubSportsman= new sportclubSportsmanForm();
                sportclubSportsman.FormClosed += sportclubSportsman_FormClosed;
            sportclubSportsman.scl2 = int.Parse(idNum1);
            sportclubSportsman.sport2 = int.Parse(idSport1);
            Hide();
                sportclubSportsman.ShowDialog();
        }

        private void sportclubSportsman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }       

        private void textBoxSname_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"nameSportclub like '%{textBoxSname.Text}%'";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"citySportcub like '%{textBoxName.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var addSportclubForm = new AddSportclubForm();
            addSportclubForm.FormClosed += addSportclubForm_FormClosed;
            Hide();
            addSportclubForm.ShowDialog();

        }

        private void addSportclubForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }

        static public string idNum2;

        private void button4_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = true;

            idNum2 = dataGridView111.CurrentRow.Cells[0].Value.ToString();
            var name = dataGridView111.CurrentRow.Cells[1].Value.ToString();
            var city = dataGridView111.CurrentRow.Cells[2].Value.ToString();
            
            textBox2.Text = name;
            textBox1.Text = city;
        }

        private void ClearE()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void buttonEditYes_Click(object sender, EventArgs e)
        {
                       

            if (textBox2.Text != "" && textBox1.Text != "")
            {
                dataBase.openConnection();

                var nameE = textBox2.Text;
                var cityE = textBox1.Text;

                var editQuery = $"update sportclub set nameSportclub = '{nameE}', citySportcub = '{cityE}' where idSportclub = '{idNum2}'";

                var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                editCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Data();
                ClearE();
                groupBoxEdit.Visible = false;
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public string idDel;

        private void button3_Click(object sender, EventArgs e)
        {
            idDel = dataGridView111.CurrentRow.Cells[0].Value.ToString();

            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery1 = $"delete from sorevnovanieSportclub where idSportclub = '{idDel}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery2 = $"delete from trenerSportclub where idSportclub = '{idDel}'";
                var delCommand2 = new SqlCommand(delQuery2, dataBase.getConnection());
                delCommand2.ExecuteNonQuery();
                var delQuery3 = $"delete from sportclub where idSportclub = '{idDel}'";
                var delCommand3 = new SqlCommand(delQuery3, dataBase.getConnection());
                delCommand3.ExecuteNonQuery();
                
                MessageBox.Show("Запись удалена");
                Data();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sport1 = int.Parse(dataGridView111.CurrentRow.Cells[3].Value.ToString());
            int sportclub1 = int.Parse(dataGridView111.CurrentRow.Cells[0].Value.ToString());

            var sportclubTrener = new SportclubTrenerForm();
            sportclubTrener.FormClosed += sportclubTrener_FormClosed;
            sportclubTrener.sport2 = sport1;
            sportclubTrener.sportclub2 = sportclub1;
            Hide();
            sportclubTrener.ShowDialog();

        }


        private void sportclubTrener_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridView111.DataSource as DataTable).DefaultView.RowFilter = $"nameSport like '%{textBox3.Text}%'";
        }

        private void buttonEditNo_Click(object sender, EventArgs e)
        {
            ClearE();
            groupBoxEdit.Visible = false;
        }
    }
}
