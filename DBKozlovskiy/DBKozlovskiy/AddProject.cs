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
    public partial class AddProject : Form
    {

        Connection dataBase = new Connection();
                
        public int dogovor3;

        public AddProject()
        {
            InitializeComponent();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            label3.Text = dogovor3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                dataBase.openConnection();

                int dog = dogovor3;
                var name = textBox1.Text;
                var price = textBox2.Text;

                var addQuery = $"insert into project (nameProject, idDogovor, priceProject) values ('{name}','{dog}','{price}')";
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
