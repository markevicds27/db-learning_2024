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
    public partial class StForm : Form
    {

        Conn dataBase = new Conn();

        public StForm()
        {
            InitializeComponent();
        }

        private void StForm_Load(object sender, EventArgs e)
        {
            Data1();
            ComboBoxSport();
            groupBox2.Visible = false;
        }

        private void Data1()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSt = new SqlCommand("select stadion.idStadion, stadion.typeStadion, stadion.nameStadion, sport.nameSport, stadion.charStadion from stadion, sport where stadion.sportStadion = sport.idSport", conn);

            SqlDataAdapter gs = new SqlDataAdapter(getSt);

            DataTable st = new DataTable();

            gs.Fill(st);

            dataGridView1.DataSource = st;
        }

        private void Data2()
        {

            int stadion = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSt = new SqlCommand("select sorevnovanieStadion.idSorevnovanieStadion, sorevnovanieStadion.idSorevnovanie, sorevnovanie.nameSorevnovanie, sorevnovanieStadion.date from sorevnovanieStadion, sorevnovanie where sorevnovanieStadion.idStadion = @idSt and sorevnovanieStadion.idSorevnovanie = sorevnovanie.idSorevnovanie", conn);

            getSt.Parameters.AddWithValue("@idSt", stadion);

            SqlDataAdapter gs = new SqlDataAdapter(getSt);

            DataTable st = new DataTable();

            gs.Fill(st);

            dataGridView2.DataSource = st;
        }

        private void ComboBoxSport()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idSport, nameSport from sport", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable orgBox = new DataTable();
            sqlDataAdapter.Fill(orgBox);
            comboBoxSport.DataSource = orgBox;
            comboBoxSport.DisplayMember = "nameSport";
            comboBoxSport.ValueMember = "idSport";
            conn.Close();
        }

        private void Clear()
        {
            textBoxAddName.Text = "";
            textBoxAddType.Text = "";
            textBoxAddChar.Text = "";
            comboBoxSport.Text = "";
        }

        private void ClearSearch()
        {
            textBoxName.Text = "";
            textBoxType.Text = "";
            textBoxChar.Text = "";
            textBoxSport.Text = "";
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typeStadion like '%{textBoxType.Text}%'";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameStadion like '%{textBoxName.Text}%'";
        }

        private void textBoxSport_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameSport like '%{textBoxSport.Text}%'";
        }

        private void textBoxChar_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"charStadion like '%{textBoxChar.Text}%'";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Data2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                if (textBoxAddName.Text != "" && textBoxAddType.Text != "" && textBoxAddChar.Text != "" && comboBoxSport.Text != "")
                {

                dataBase.openConnection();

                var name = textBoxAddName.Text;
                var type = textBoxAddType.Text;
                int sport = int.Parse(comboBoxSport.SelectedValue.ToString());
                var ch = textBoxAddChar.Text;

                var addQuery = $"insert into stadion (nameStadion, typeStadion, sportStadion, charStadion) values ('{name}', '{type}',  '{sport}', '{ch}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    Data1();
                    groupBox2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            groupBox2.Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idDel = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delsorst = $"delete from sorevnovanieStadion where idStadion = '{idDel}'";
                var delSorSt = new SqlCommand(delsorst, dataBase.getConnection());
                delSorSt.ExecuteNonQuery();
                var delst = $"delete from stadion where idStadion = '{idDel}'";
                var delSt = new SqlCommand(delst, dataBase.getConnection());
                delSt.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data1();
            }
        }        

        private void button5_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        
    }
}
