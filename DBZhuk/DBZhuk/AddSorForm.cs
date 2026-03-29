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
    public partial class AddSorForm : Form
    {

        Conn dataBase = new Conn();

        public AddSorForm()
        {
            InitializeComponent();
        }

        private void AddSorForm_Load(object sender, EventArgs e)
        {
            ComboBoxSport();
            ComboBoxType();
        }

        private void Clear()
        {
            textBoxName.Text = "";
            comboBoxSport.Text = "";
            comboBoxType.Text = "";
            dateTimePickerStart.Text = "";
            dateTimePickerFinish.Text = "";
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

        private void ComboBoxType()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idType, nameType from type", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable typeBox = new DataTable();
            sqlDataAdapter.Fill(typeBox);
            comboBoxType.DataSource = typeBox;
            comboBoxType.DisplayMember = "nameType";
            comboBoxType.ValueMember = "idType";
            conn.Close();
        }

        private void buttonAddStYes_Click(object sender, EventArgs e)
        {
            
            if (textBoxName.Text != " " && comboBoxSport.Text != "" && comboBoxType.Text != "" && dateTimePickerStart.Value != null && dateTimePickerFinish.Value != null)
            {
                

                dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
                dateTimePickerFinish.CustomFormat = "yyyy-MM-dd";

                DateTime start = dateTimePickerStart.Value;
                DateTime finish = dateTimePickerFinish.Value;
                if (start < finish)
                {
                    dataBase.openConnection();
                    
                    var name = textBoxName.Text;

                    int sport = int.Parse(comboBoxSport.SelectedValue.ToString());

                    int type = int.Parse(comboBoxType.SelectedValue.ToString());



                    var addQuery = $"insert into sorevnovanie (nameSorevnovanie, sportSorevnovanie, typeSorevnovanie, dateStartSorevnovanie, dateFinishSorevnovanie) values ('{name}','{sport}','{type}','{start}','{finish}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Дата конца не может быть раньше даты начала соревнования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
