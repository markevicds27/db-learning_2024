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

namespace DBMarkevich
{
    public partial class StatusForm : Form
    {

        DataBase dataBase = new DataBase();

        public StatusForm()
        {
            InitializeComponent();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsS();
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getStatus = new SqlCommand("select * from status", conn);

            SqlDataAdapter gs = new SqlDataAdapter(getStatus);

            DataTable status = new DataTable();

            gs.Fill(status);

            dataGridView1.DataSource = status;
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxOp.Text = "";
            textBoxZp.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxNameS.Text = "";
            textBoxZpS.Text = "";
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBoxName.Text;
            var op = textBoxOp.Text;
            var zp = textBoxZp.Text;

            if (textBoxName.Text != "" && textBoxOp.Text != "" && textBoxZp.Text != "")
            {
                var addQuery = $"insert into status (namestatus, opstatus, money) values ('{name}','{op}', '{zp}')";

                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                addCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GetData();
                groupBoxAdd.Visible = false;
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddNo_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
        }


        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namestatus like '%{textBoxNameS.Text}%'";
        }

        private void textBoxZpS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(money, 'System.String') like '%{textBoxZpS.Text}%'";
        }
    }
}
