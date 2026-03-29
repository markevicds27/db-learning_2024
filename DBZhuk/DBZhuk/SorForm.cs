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
    public partial class SorForm : Form
    {

        Conn dataBase = new Conn();

        public SorForm()
        {
            InitializeComponent();
        }

        private void SorForm_Load(object sender, EventArgs e)
        {
            DataSor();          
            groupBoxAddOrg.Visible = false;
            groupBoxAddSt.Visible = false;
            
        }

        private void DataSor()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSor = new SqlCommand("select sorevnovanie.idSorevnovanie, sorevnovanie.nameSorevnovanie, sorevnovanie.sportSorevnovanie, sport.nameSport, sorevnovanie.typeSorevnovanie ,type.nameType, sorevnovanie.dateStartSorevnovanie, sorevnovanie.dateFinishSorevnovanie from sorevnovanie, sport, type where sorevnovanie.sportSorevnovanie = sport.idSport and sorevnovanie.typeSorevnovanie = type.idType", conn);


            SqlDataAdapter gs = new SqlDataAdapter(getSor);

            DataTable sor = new DataTable();

            gs.Fill(sor);

            dataGridViewSor.DataSource = sor;           
        }

        private void ClearSt()
        {
            comboBoxSt.Text = "";
            dateTimePickerSt.Text = "";
        }

        private void ClearOrg()
        {
            comboBoxOrg.Text = "";
            textBoxMoney.Text = "";
        }

        private void ComboBoxSt()
        {
            int sport = int.Parse(dataGridViewSor.CurrentRow.Cells[2].Value.ToString());
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idStadion, nameStadion from stadion where sportStadion = @idSport", conn);
            loadBox.Parameters.AddWithValue("@idSport", sport);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable stBox = new DataTable();
            sqlDataAdapter.Fill(stBox);
            comboBoxSt.DataSource = stBox;
            comboBoxSt.DisplayMember = "nameStadion";
            comboBoxSt.ValueMember = "idStadion";            
            conn.Close();
        }

        private void ComboBoxOrg()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idOrganizator, nameOrganizator from organizator", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable orgBox = new DataTable();
            sqlDataAdapter.Fill(orgBox);
            comboBoxOrg.DataSource = orgBox;
            comboBoxOrg.DisplayMember = "nameOrganizator";
            comboBoxOrg.ValueMember = "idOrganizator";
            conn.Close();
        }

        private void dataGridViewSor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idSor = int.Parse(dataGridViewSor.CurrentRow.Cells[0].Value.ToString());

            int idType = int.Parse(dataGridViewSor.CurrentRow.Cells[4].Value.ToString());

            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSt = new SqlCommand("select sorevnovanieStadion.idSorevnovanieStadion , stadion.nameStadion, stadion.typeStadion, sorevnovanieStadion.date from sorevnovanieStadion, stadion where sorevnovanieStadion.idSorevnovanie = @idSor and sorevnovanieStadion.idStadion = stadion.idStadion", conn);

            getSt.Parameters.AddWithValue("@idSor", idSor);

            SqlDataAdapter gst = new SqlDataAdapter(getSt);

            DataTable st = new DataTable();

            gst.Fill(st);

            dataGridViewSt.DataSource = st;

           

            SqlCommand getOrg = new SqlCommand("select sorevnovanieOrganizator.idSorevnovanieOrganizator, organizator.nameOrganizator, organizator.typeOrganizator, sorevnovanieOrganizator.money from sorevnovanieOrganizator, organizator where sorevnovanieOrganizator.idSorevnovanie = @idSor and sorevnovanieOrganizator.idOrganizator = organizator.idOrganizator", conn);

            getOrg.Parameters.AddWithValue("@idSor", idSor);

            SqlDataAdapter go = new SqlDataAdapter(getOrg);

            DataTable org = new DataTable();

            go.Fill(org);

            dataGridViewOrg.DataSource = org;

            if(idType == 4)
            {
                SqlCommand getSpm = new SqlCommand("select sportsman.sNameSportsman as 'Фамилия', sportsman.nameSportsman as 'Имя', sportsman.pNameSportsman as 'Отчесвто', sportsman.genderSportsman as 'Пол', sportsman.ageSportsman as 'Возраст' from sorevnovanieSportsman, sportsman where sorevnovanieSportsman.idSorevnovanie = @idSt1 and sorevnovanieSportsman.idSportsman = sportsman.idSportsman", conn);

                getSpm.Parameters.AddWithValue("@idSt1", idSor);

                SqlDataAdapter gspm = new SqlDataAdapter(getSpm);

                DataTable spm = new DataTable();

                gspm.Fill(spm);

                dataGridViewPlayer.DataSource = spm;
            }
            else if(idType == 5) 
            {
                SqlCommand getScl = new SqlCommand("select sportclub.nameSportclub as 'Название', sportclub.citySportcub as 'Город' from sorevnovanieSportclub, sportclub where sorevnovanieSportclub.idSorevnovanie = @idSt1 and sorevnovanieSportclub.idSportclub = sportclub.idSportclub", conn);

                getScl.Parameters.AddWithValue("@idSt1", idSor);

                SqlDataAdapter gscl = new SqlDataAdapter(getScl);

                DataTable scl = new DataTable();

                gscl.Fill(scl);

                dataGridViewPlayer.DataSource = scl;
            }

            
        }

        private void buttonAddSt_Click(object sender, EventArgs e)
        {
            groupBoxAddSt.Visible = true;
            
            ComboBoxSt();

        }

        private void buttonAddOrg_Click(object sender, EventArgs e)
        {
            groupBoxAddOrg.Visible = true;
            ComboBoxOrg();
            
        }
        

        
        private void button1_Click(object sender, EventArgs e)
        {
            int idDel = int.Parse(dataGridViewSt.CurrentRow.Cells[0].Value.ToString());
            
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from sorevnovanieStadion where idSorevnovanieStadion = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                DataSor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idDel = int.Parse(dataGridViewOrg.CurrentRow.Cells[0].Value.ToString());
            
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from sorevnovanieOrganizator where idSorevnovanieOrganizator = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                DataSor();
            }
        }

        private void buttonAddStYes_Click(object sender, EventArgs e)
        {
            
            

            if (comboBoxSt.Text != "")
            {
                dataBase.openConnection();

                dateTimePickerSt.CustomFormat = "yyyy-MM-dd";

                int idSor = int.Parse(dataGridViewSor.CurrentRow.Cells[0].Value.ToString());

                int st = int.Parse(comboBoxSt.SelectedValue.ToString());
                DateTime dateTime = dateTimePickerSt.Value;

                var addQuery = $"insert into sorevnovanieStadion (idSorevnovanie, idStadion, date) values ('{idSor}','{st}','{dateTime}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSt();
                DataSor();
                groupBoxAddSt.Visible = false;
            }
            else
            {
                MessageBox.Show("Возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddStNo_Click(object sender, EventArgs e)
        {
            ClearSt();
            groupBoxAddSt.Visible= false;
        }

        private void buttonAddOrgYes_Click(object sender, EventArgs e)
        {
            


            if (comboBoxSt.Text != "null")
            {
                dataBase.openConnection();



                int idSor = int.Parse(dataGridViewSor.CurrentRow.Cells[0].Value.ToString());

                int org = int.Parse(comboBoxOrg.SelectedValue.ToString());
                var money = textBoxMoney.Text;

                var addQuery = $"insert into sorevnovanieOrganizator (idSorevnovanie, idOrganizator, money) values ('{idSor}','{org}','{money}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearOrg();
                DataSor();
                groupBoxAddOrg.Visible = false;
            }
            else
            {
                MessageBox.Show("Возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddOrgNo_Click(object sender, EventArgs e)
        {
            ClearOrg();
            groupBoxAddOrg.Visible= false;
        }

        private void buttonDelSor_Click(object sender, EventArgs e)
        {
            int idDel = int.Parse(dataGridViewSor.CurrentRow.Cells[0].Value.ToString());

            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delSororg = $"delete from sorevnovanieOrganizator where idSorevnovanie = '{idDel}'";
                var delSorOrg = new SqlCommand(delSororg, dataBase.getConnection());
                delSorOrg.ExecuteNonQuery();
                var delSorst = $"delete from sorevnovanieStadion where idSorevnovanie = '{idDel}'";
                var delSorSt = new SqlCommand(delSorst, dataBase.getConnection());
                delSorSt.ExecuteNonQuery();
                var delSorspm = $"delete from sorevnovanieSportsman where idSorevnovanie = '{idDel}'";
                var delSorSpm = new SqlCommand(delSorspm, dataBase.getConnection());
                delSorSpm.ExecuteNonQuery();
                var delSorscl = $"delete from sorevnovanieSportclub where idSorevnovanie = '{idDel}'";
                var delSorScl = new SqlCommand(delSorscl, dataBase.getConnection());
                delSorScl.ExecuteNonQuery();
                var delSor = $"delete from sorevnovanie where idSorevnovanie = '{idDel}'";
                var DelSor = new SqlCommand(delSor, dataBase.getConnection()) ;
                DelSor.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                DataSor();
            }
        }

        private void buttonAddSor_Click(object sender, EventArgs e)
        {
            
            var addSor= new AddSorForm();
                addSor.FormClosed += addSor_FormClosed;
            Hide();
                addSor.ShowDialog();

        }


        private void addSor_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataSor();
            Show();
            
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {

            int idType = int.Parse(dataGridViewSor.CurrentRow.Cells[4].Value.ToString());
            
            if (idType == 4)
            {
                int sor1 = int.Parse(dataGridViewSor.CurrentRow.Cells[0].Value.ToString());
                int sport1 = int.Parse(dataGridViewSor.CurrentRow.Cells[2].Value.ToString());
               
                var addspm= new AddSpmForm();
                    addspm.FormClosed += addspm_FormClosed;
                addspm.sor2 = sor1;
                addspm.sport2 = sport1;
                Hide();
                    addspm.ShowDialog();

            }
            else if (idType == 5)
            {
                int sor1 = int.Parse(dataGridViewSor.CurrentRow.Cells[0].Value.ToString());
                int sport1 = int.Parse(dataGridViewSor.CurrentRow.Cells[2].Value.ToString());
                
                var addscl= new AddSclForm();
                    addscl.FormClosed += addscl_FormClosed;
                addscl.sor3 = sor1;
                addscl.sport3 = sport1;
                Hide();
                    addscl.ShowDialog();

            }
        }

        

        private void addspm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            DataSor();
        }

        private void addscl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            DataSor();
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewSor.DataSource as DataTable).DefaultView.RowFilter = $"nameSorevnovanie like '%{textBoxSearchName.Text}%'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchTypr.SelectedIndex)
            {
                case 0:
                    (dataGridViewSor.DataSource as DataTable).DefaultView.RowFilter = $"typeSorevnovanie =4";
                    break;
                case 1:
                    (dataGridViewSor.DataSource as DataTable).DefaultView.RowFilter = $"typeSorevnovanie = 5";
                    break;
                case 2:
                    (dataGridViewSor.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void textBoxSearchSport_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewSor.DataSource as DataTable).DefaultView.RowFilter = $"nameSport like '%{textBoxSearchSport.Text}%'";
        }
    }
}
