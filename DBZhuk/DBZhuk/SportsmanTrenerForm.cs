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
    public partial class SportsmanTrenerForm : Form
    {

        Conn dataBase = new Conn();

        public int sport2;
        public int sportsman2;

        public SportsmanTrenerForm()
        {
            InitializeComponent();
        }

        private void SportsmanTrenerForm_Load(object sender, EventArgs e)
        {
            Data1();
            Data2();
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void Data1()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getPlayer = new SqlCommand("select trener.idTrener, trener.sNameTrener as 'Фамилия', trener.nameTrener as 'Имя', trener.pNameTrener as 'Отчество', trener.genderTrener as 'Пол', trener.ageTrener as 'Возраст', trener.stazTrener as 'Стаж' from sportsmanTrener, trener, sportsmanSport where sportsmanTrener.idTrener = trener.idTrener and sportsmanTrener.idSportsman = @idSportsman and sportsmanSport.idSportsman = @idSportsman and sportsmanSport.idSport = @idSport", conn);

            getPlayer.Parameters.AddWithValue("@idSportsman", sportsman2);
            getPlayer.Parameters.AddWithValue("@idSport", sport2);

            SqlDataAdapter gp = new SqlDataAdapter(getPlayer);

            DataTable player = new DataTable();

            gp.Fill(player);

            dataGridView1.DataSource = player;
        }

        private void Data2()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSpm = new SqlCommand("select trener.idTrener, trener.sNameTrener, trener.nameTrener, trener.pNameTrener, trener.genderTrener, trener.ageTrener, trener.stazTrener from trener where trener.sportTrener = @idSport", conn);

            getSpm.Parameters.AddWithValue("@idSport", sport2);

            SqlDataAdapter gs = new SqlDataAdapter(getSpm);

            DataTable spm = new DataTable();

            gs.Fill(spm);

            dataGridView2.DataSource = spm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int idSpm1 = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getSpm = new SqlCommand("select sportsmanTrener.idSportsman from sportsmanTrener where sportsmanTrener.idTrener = @idTrener", conn);

            getSpm.Parameters.AddWithValue("@idTrener", idSpm1);

            Object result = getSpm.ExecuteScalar();

            if (result == null)
            {

                dataBase.openConnection();

                int idTr = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                int idSpm = sportsman2;

                var addQuery = $"insert into sportsmanTrener (idSportsman, idTrener) values ('{idSpm}','{idTr}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data1();
            }
            else
            {
                MessageBox.Show("Данный спортсмен уже тренируется у этого тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idTr = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int idDel = sportsman2;


            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delSororg = $"delete from sportsmanTrener where idSportsman = '{idDel}' and idTrener = '{idTr}'";
                var delSorOrg = new SqlCommand(delSororg, dataBase.getConnection());
                delSorOrg.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data1();
            }
        }

        

        
    }
}
