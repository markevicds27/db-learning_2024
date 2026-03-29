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

namespace DBKozlovskiy
{
    public partial class NewWorker : Form
    {

        Connection dataBase = new Connection();

        public NewWorker()
        {
            InitializeComponent();
        }

        private void NewWorker_Load(object sender, EventArgs e)
        {
            ComboBoxDol();
            ComboBoxOtdel();
        }

        private void ComboBoxDol()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idDolzhnost, nameDolznost from dolzhnost", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable box = new DataTable();
            sqlDataAdapter.Fill(box);
            comboBoxDol.DataSource = box;
            comboBoxDol.DisplayMember = "nameDolznost";
            comboBoxDol.ValueMember = "idDolzhnost";
            conn.Close();
        }

        private void ComboBoxOtdel()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBoxO = new SqlCommand("select idOtdel, nameOtdel from otdel", conn);
            SqlDataAdapter sqlDataAdapterO = new SqlDataAdapter(loadBoxO);
            sqlDataAdapterO.SelectCommand = loadBoxO;
            DataTable boxO = new DataTable();
            sqlDataAdapterO.Fill(boxO);
            comboBoxOtdel.DataSource = boxO;
            comboBoxOtdel.DisplayMember = "nameOtdel";
            comboBoxOtdel.ValueMember = "idOtdel";
            conn.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text != "" && textBoxName.Text != "" && textBoxPatron.Text != "" && textBoxAge.Text != "" && textBoxStaz.Text != "" && comboBoxDol.Text != "" && comboBoxOtdel.Text != "")
            {
                dataBase.openConnection();

                var surname = textBoxSurname.Text;
                var name = textBoxName.Text;
                var patron = textBoxPatron.Text;
                int age;
                int staz;
                int dol = int.Parse(comboBoxDol.SelectedValue.ToString());
                int otdel = int.Parse(comboBoxOtdel.SelectedValue.ToString());
                if (int.TryParse(textBoxAge.Text, out age))
                {
                    if (int.TryParse(textBoxStaz.Text, out staz))
                    {

                        var addQuery = $"insert into worker (surnameWorker, nameWorker, patronWorker, ageWorker, stazWorker) values ('{surname}','{name}','{patron}', '{age}', '{staz}')";

                        var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                        addCommand.ExecuteNonQuery();

                        var selectId = $"select MAX(idWorker) from worker";

                        var selectCommand = new SqlCommand(selectId, dataBase.getConnection());

                        var id = selectCommand.ExecuteScalar().ToString();

                        int worker = int.Parse(id);

                        var addQuery1 = $"insert into status (idWorker, idDolzhnost, idOtdel) values ('{worker}','{dol}','{otdel}')";

                        var addCommand1 = new SqlCommand(addQuery1, dataBase.getConnection());

                        addCommand1.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число в поле стаж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите целое число в поле возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
