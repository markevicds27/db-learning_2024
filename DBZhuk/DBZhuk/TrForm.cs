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
    public partial class TrForm : Form
    {

        Conn dataBase = new Conn();

        public TrForm()
        {
            InitializeComponent();
        }

        private void TrForm_Load(object sender, EventArgs e)
        {
            Data();
        }

        private void Data()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getTr = new SqlCommand("select trener.idTrener, trener.sNameTrener, trener.nameTrener, trener.pNameTrener, trener.genderTrener, trener.ageTrener, trener.stazTrener, sport.namesport, trener.sportTrener from trener, sport where trener.sportTrener = sport.idSport", conn);

            SqlDataAdapter gt = new SqlDataAdapter(getTr);

            DataTable tr = new DataTable();

            gt.Fill(tr);

            dataGridView1.DataSource = tr;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTr = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSt = new SqlCommand("select sportsman.idSportsman, sportsman.sNameSportsman, sportsman.nameSportsman, sportsman.pNameSportsman, sportsman.genderSportsman, sportsman.ageSportsman from sportsman, sportsmanTrener where sportsmanTrener.idTrener = @idTr and sportsmanTrener.idSportsman = sportsman.idSportsman", conn);

            getSt.Parameters.AddWithValue("@idTr", idTr);

            SqlDataAdapter gst = new SqlDataAdapter(getSt);

            DataTable st = new DataTable();

            gst.Fill(st);

            dataGridView2.DataSource = st;



            SqlCommand getOrg = new SqlCommand("select sportclub.idSportclub, sportclub.nameSportclub, sportclub.citySportcub from trenerSportclub, sportclub where trenerSportclub.idTrener = @idTr and trenerSportclub.idSportclub = sportclub.idSportclub", conn);

            getOrg.Parameters.AddWithValue("@idTr", idTr);

            SqlDataAdapter go = new SqlDataAdapter(getOrg);

            DataTable org = new DataTable();

            go.Fill(org);

            dataGridView3.DataSource = org;
        }

        private void textBoxSport_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameSport like '%{textBoxSport.Text}%'";
        }

        private void buttonAddTr_Click(object sender, EventArgs e)
        {
            
            var addTr= new AddTr();
                addTr.FormClosed += addTr_FormClosed;
            Hide();
            addTr.ShowDialog();

        }

        private void addTr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameTrener like '%{textBoxName.Text}%'";
        }

        private void textBoxPname_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"pNameTrener like '%{textBoxPname.Text}%'";
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxGender.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"genderTrener = 'Мужской'";
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"genderTrener = 'Женский'";
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(ageTrener, 'System.String') like '%{textBoxAge.Text}%'";
        }

        private void textBoxStaz_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(stazTrener, 'System.String') like '%{textBoxStaz.Text}%'";
        }

        private void textBoxSname_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"sNameTrener like '%{textBoxSname.Text}%'";
        }

        private void buttonDelTr_Click(object sender, EventArgs e)
        {
            int idDel = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery1 = $"delete from trenerSportclub where idTrener = '{idDel}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery2 = $"delete from sportsmanTrener where idTrener = '{idDel}'";
                var delCommand2 = new SqlCommand(delQuery2, dataBase.getConnection());
                delCommand2.ExecuteNonQuery();
                var delQuery = $"delete from trener where idTrener = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data();
            }
        }

        private void buttonSpm_Click(object sender, EventArgs e)
        {
            int tr1 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int sport1 = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            
            var addspm= new trSpmForm();
                addspm.FormClosed += addspm_FormClosed;
            addspm.tr2 = tr1;
            addspm.sport2 = sport1;
            Hide();
            addspm.ShowDialog();

        }

        private void addspm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }

        private void buttonScl_Click(object sender, EventArgs e)
        {
            int tr1 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int sport1 = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            
            var addscl= new trSclForm();
                addscl.FormClosed += addscl_FormClosed;
            addscl.tr3 = tr1;
            addscl.sport3 = sport1;
            Hide();
                addscl.ShowDialog();

        }



        private void addscl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Data();
        }
    }
}
