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
    public partial class AddSportsmanForm : Form
    {

        Conn dataBase = new Conn();

        public AddSportsmanForm()
        {
            InitializeComponent();
        }

        private void AddSportsmanForm_Load(object sender, EventArgs e)
        {
            ComboBoxSport();           
        }

        private void Clear()
        {
            textBoxSurame.Text = "";
            textBoxName.Text = "";
            textBoxPatron.Text = "";
            comboBoxGender.Text = "";
            textBoxAge.Text = "";
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
            

            if (textBoxSurame.Text != "" && textBoxName.Text != "" && textBoxPatron.Text != "" && textBoxAge.Text != "" && comboBoxSport.Text != "" && comboBoxGender.Text != "")
            {
                dataBase.openConnection();

                var surname = textBoxSurame.Text;
                var name = textBoxName.Text;
                var patron = textBoxPatron.Text;
                int age;
                var gender = comboBoxGender.Text;
                int sport = int.Parse(comboBoxSport.SelectedValue.ToString());

                if (int.TryParse(textBoxAge.Text, out age))
                {
                    var addQuery = $"insert into sportsman (sNameSportsman, nameSportsman, pNameSportsman, genderSportsman, ageSportsman) values ('{surname}','{name}','{patron}','{gender}','{age}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    var selectId = $"select MAX(idSportsman) from sportsman";

                    var selectCommand = new SqlCommand(selectId, dataBase.getConnection());

                    var id = selectCommand.ExecuteScalar().ToString();

                    int spm = int.Parse(id);

                    var addSport = $"insert into sportsmanSport (idSportsman, idSport) values ('{spm}','{sport}')";

                    var addSport1 = new SqlCommand(addSport, dataBase.getConnection());

                    addSport1.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите целое число в возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
