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
    public partial class AddSportclubForm : Form
    {

        Conn dataBase = new Conn();

        public AddSportclubForm()
        {
            InitializeComponent();
        }

        private void AddSportclubForm_Load(object sender, EventArgs e)
        {
            ComboBoxSport();
        }

        private void Clear()
        {
            textBoxCity.Text = "";
            textBoxName.Text = "";
            
            comboBoxSport.Text = "";

        }

        private void ComboBoxSport()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idSport, nameSport from sport", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable sportBox = new DataTable();
            sqlDataAdapter.Fill(sportBox);
            comboBoxSport.DataSource = sportBox;
            comboBoxSport.DisplayMember = "nameSport";
            comboBoxSport.ValueMember = "idSport";
            conn.Close();
        }

        private void buttonAddStYes_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            
            var name = textBoxName.Text;
            var city = textBoxCity.Text;            
            int sport = int.Parse(comboBoxSport.SelectedValue.ToString());

            if (textBoxName.Text != "" && textBoxCity.Text != "" && comboBoxSport.Text != "")
            {
                var addQuery = $"insert into sportclub (nameSportclub, citySportcub, sportSportclub) values ('{name}','{city}','{sport}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();                

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();

                this.Close();


            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
