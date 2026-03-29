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
    public partial class trSclForm : Form
    {

        Conn dataBase = new Conn();

        public int tr3;

        public int sport3;

        public trSclForm()
        {
            InitializeComponent();
        }

        private void trSclForm_Load(object sender, EventArgs e)
        {
            Data1();
            Data2();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void Data1()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getClub = new SqlCommand("select trenerSportclub.idSportclub, sportclub.nameSportclub as 'Название', sportclub.citySportcub as 'Город' from trenerSportclub, sportclub where trenerSportclub.idTrener = @idSor and trenerSportclub.idSportclub = sportclub.idSportclub", conn);

            getClub.Parameters.AddWithValue("@idSor", tr3);

            SqlDataAdapter gc = new SqlDataAdapter(getClub);

            DataTable club = new DataTable();

            gc.Fill(club);

            dataGridView1.DataSource = club;
        }

        private void Data2()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getScl = new SqlCommand("select * from sportclub where sportclub.sportSportclub = @idSport", conn);

            getScl.Parameters.AddWithValue("@idSport", sport3);

            SqlDataAdapter gs = new SqlDataAdapter(getScl);

            DataTable scl = new DataTable();

            gs.Fill(scl);

            dataGridView2.DataSource = scl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int idScl1 = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getScl = new SqlCommand("select trenerSportclub.idTrener from trenerSportclub where trenerSportclub.idSportclub = @idSportclub", conn);

            getScl.Parameters.AddWithValue("@idSportclub", idScl1);

            Object result = getScl.ExecuteScalar();

            if (result == null)
            {

                dataBase.openConnection();

                int idScl = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                int idTr = tr3;

                var addQuery = $"insert into trenerSportclub (idTrener, idSportclub) values ('{idTr}','{idScl}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data1();
            }
            else
            {
                MessageBox.Show("Данный спортклуб уже тренируется у этого тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idScl = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int idDel = tr3;


            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delSorscl = $"delete from trenerSportclub where idTrener = '{idDel}' and idSportclub = '{idScl}'";
                var delSorScl = new SqlCommand(delSorscl, dataBase.getConnection());
                delSorScl.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data1();
            }
        }

        
    }
}
