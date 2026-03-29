using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBZhuk
{
    public partial class sportclubSportsmanForm : Form
    {

        Conn dataBase = new Conn();

        public int sport2;
        public int scl2;

        public sportclubSportsmanForm()
        {
            InitializeComponent();
        }

        private void sportclubSportsmanForm_Load(object sender, EventArgs e)
        {
            Data1();
            Data2();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void Data1()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getPlayer = new SqlCommand("select sportsman.idSportsman, sportsman.sNameSportsman as 'Фамилия', sportsman.nameSportsman as 'Имя', sportsman.pNameSportsman as 'Отчество', sportsman.genderSportsman as 'Пол', sportsman.ageSportsman as 'Возраст' from sportsman where sportsman.idSportclub = @idScl", conn);

            getPlayer.Parameters.AddWithValue("@idScl", scl2);
            

            SqlDataAdapter gp = new SqlDataAdapter(getPlayer);

            DataTable player = new DataTable();

            gp.Fill(player);

            dataGridView1.DataSource = player;
        }

        private void Data2()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSpm = new SqlCommand("select sportsman.idSportsman, sportsman.sNameSportsman, sportsman.nameSportsman, sportsman.pNameSportsman, sportsman.genderSportsman, sportsman.ageSportsman from sportsman, sportsmanSport where sportsman.idSportclub is null and  sportsmanSport.idSportsman = sportsman.idSportsman and sportsmanSport.idSport = @idSport", conn);

            getSpm.Parameters.AddWithValue("@idSport", sport2);

            SqlDataAdapter gs = new SqlDataAdapter(getSpm);

            DataTable spm = new DataTable();

            gs.Fill(spm);

            dataGridView111.DataSource = spm;
        }

       
        static public string idSpm;

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int idScl = scl2;
            idSpm = dataGridView111.CurrentRow.Cells[0].Value.ToString();

            var addQuery = $"update sportsman set idSportclub = '{idScl}' where idSportsman = '{idSpm}'";
            var addCommand = new SqlCommand(addQuery, dataBase.getConnection());
            addCommand.ExecuteNonQuery();

            MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Data1();
            Data2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idSpm = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var addQuery = $"update sportsman set idSportclub = null where idSportsman = '{idSpm}'";
                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());
                addCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data1();
                Data2();
            }
        }
    }
}
