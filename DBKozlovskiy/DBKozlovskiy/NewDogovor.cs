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

namespace DBKozlovskiy
{
    public partial class NewDogovor : Form
    {

        Connection dataBase = new Connection();

        public NewDogovor()
        {
            InitializeComponent();
        }

        private void NewDogovor_Load(object sender, EventArgs e)
        {
            ComboBoxZakaz();
        }

        private void ComboBoxZakaz()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idZakaz, nameZakaz from zakaz", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable box = new DataTable();
            sqlDataAdapter.Fill(box);
            comboBoxZakaz.DataSource = box;
            comboBoxZakaz.DisplayMember = "nameZakaz";
            comboBoxZakaz.ValueMember = "idZakaz";
            conn.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && comboBoxStatus.Text != "" && comboBoxZakaz.Text != "" && dateTimePicker1.Value != null && dateTimePicker2.Value != null)
            {
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                DateTime date1 = dateTimePicker1.Value;
                DateTime date2 = dateTimePicker2.Value;

                if (date1 < date2)
                {
                    dataBase.openConnection();


                    var name = textBoxName.Text;
                    int zakaz = int.Parse(comboBoxZakaz.SelectedValue.ToString());
                    var status = comboBoxStatus.Text;


                    var addQuery = $"insert into dogovor (nameDogovor, idZakaz, statusDogovor, dateStartDogovor, dateFibishDogovor) values ('{name}','{zakaz}', '{status}', '{date1}', '{date2}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Срок выполнения не может быть раньше даты заключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
