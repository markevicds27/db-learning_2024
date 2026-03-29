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
    public partial class NewOtdel : Form
    {

        Connection dataBase = new Connection();

        public NewOtdel()
        {
            InitializeComponent();
        }

        private void NewOtdel_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxChar.Text != "" && textBoxName.Text != "")
            {
                dataBase.openConnection();

                var name = textBoxName.Text;
                var ch = textBoxChar.Text;

                var addQuery = $"insert into otdel (nameOtdel, opisanieOtdel) values ('{name}','{ch}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
