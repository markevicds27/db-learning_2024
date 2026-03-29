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
using System.Windows.Forms.VisualStyles;

namespace DBKozlovskiy
{
    public partial class NewPodryad : Form
    {

        Connection dataBase = new Connection();

        public NewPodryad()
        {
            InitializeComponent();
        }

        private void NewPodryad_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxFace.Text != "")
            {
                dataBase.openConnection();

                var name = textBoxName.Text;
                var face = textBoxFace.Text;

                var addQuery = $"insert into podryad (namePodryad, facePodryad) values ('{name}','{face}')";

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
