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
using System.Xml.Linq;

namespace DBZhuk
{
    public partial class OrgForm : Form
    {

        Conn dataBase = new Conn();

        public OrgForm()
        {
            InitializeComponent();
        }

        private void OrgForm_Load(object sender, EventArgs e)
        {
            Data();
        }

        private void Data()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getOrg = new SqlCommand("select * from organizator", conn);

            SqlDataAdapter go = new SqlDataAdapter(getOrg);

            DataTable org = new DataTable();

            go.Fill(org);

            dataGridView1.DataSource = org;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int org = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSor = new SqlCommand("select sorevnovanieOrganizator.idSorevnovanie, sorevnovanie.nameSorevnovanie, type.nameType, sport.nameSport from sorevnovanieOrganizator, sorevnovanie, type, sport where sorevnovanieOrganizator.idOrganizator = @idOrg and sorevnovanieOrganizator.idSorevnovanie = sorevnovanie.idSorevnovanie and sorevnovanie.sportSorevnovanie = sport.idSport and sorevnovanie.typeSorevnovanie = type.idType", conn);

            getSor.Parameters.AddWithValue("idOrg", org);

            SqlDataAdapter gs = new SqlDataAdapter(getSor);

            DataTable sor = new DataTable();

            gs.Fill(sor);

            dataGridView2.DataSource = sor;
        }

        private void Clear()
        {
            textBoxName.Text = "";
            textBoxType.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBoxName.Text != "" && textBoxType.Text != "")
            {
                dataBase.openConnection();

                var name = textBoxName.Text;
                var type = textBoxType.Text;

                var addQuery = $"insert into organizator (nameOrganizator, typeOrganizator) values ('{name}', '{type}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();

                Data();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idDel = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult del = MessageBox.Show("Все данные будут удалены, вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();

                var delsororg = $"delete from sorevnovanieOrganizator where idOrganizator = '{idDel}'";
                var delSorOrg = new SqlCommand(delsororg, dataBase.getConnection());
                delSorOrg.ExecuteNonQuery();
                var delorg = $"delete from organizator where idOrganizator = '{idDel}'";
                var delOrg = new SqlCommand(delorg, dataBase.getConnection());
                delOrg.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                Data();
            }
        }

       
    }
}
