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

namespace DBZhuk
{
    public partial class AddSpmForm : Form
    {

        Conn dataBase = new Conn();

        public int sor2;
        public int sport2;

        public AddSpmForm()
        {
            InitializeComponent();
        }

        private void AddSpmForm_Load(object sender, EventArgs e)
        {
            Data1();
            Data2();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void Data1()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getPlayer = new SqlCommand("select sorevnovanieSportsman.idSportsman, sportsman.sNameSportsman as 'Фамилия', sportsman.nameSportsman as 'Имя', sportsman.pNameSportsman as 'Отчество', sportsman.genderSportsman as 'Пол', sportsman.ageSportsman as 'Возраст' from sorevnovanieSportsman, sportsman where sorevnovanieSportsman.idSorevnovanie = @idSor and sorevnovanieSportsman.idSportsman = sportsman.idSportsman", conn);

            getPlayer.Parameters.AddWithValue("@idSor", sor2);

            SqlDataAdapter gp = new SqlDataAdapter(getPlayer);

            DataTable player = new DataTable();

            gp.Fill(player);

            dataGridView1.DataSource = player;
        }

        private void Data2()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSpm = new SqlCommand("select sportsman.idSportsman, sportsman.sNameSportsman, sportsman.nameSportsman, sportsman.pNameSportsman, sportsman.genderSportsman, sportsman.ageSportsman from sportsman, sportsmanSport where sportsmanSport.idSportsman = sportsman.idSportsman and sportsmanSport.idSport = @idSport", conn);

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

            SqlCommand getSpm = new SqlCommand("select sorevnovanieSportsman.idSorevnovanie from sorevnovanieSportsman where sorevnovanieSportsman.idSportsman = @idSportsman", conn);

            getSpm.Parameters.AddWithValue("@idSportsman", idSpm1);

            Object result = getSpm.ExecuteScalar();

            if (result == null)
            {

                dataBase.openConnection();

                int idSpm = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                int idSor = sor2;

                var addQuery = $"insert into sorevnovanieSportsman (idSorevnovanie, idSportsman) values ('{idSor}','{idSpm}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data1();
            }
            else
            {
                MessageBox.Show("Данный спортсмен уже учавствует в этом соревновании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idSpm = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int idDel = sor2;


            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delspm = $"delete from sorevnovanieSportsman where idSorevnovanie = '{idDel}' and idSportsman = '{idSpm}'";
                var delSpm = new SqlCommand(delspm, dataBase.getConnection());
                delSpm.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data1();
            }
        }

        
    }
}
