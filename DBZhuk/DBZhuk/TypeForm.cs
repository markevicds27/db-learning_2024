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
    public partial class TypeForm : Form
    {

        Conn dataBase = new Conn();

        public TypeForm()
        {
            InitializeComponent();
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            Data();
        }

        private void Data()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getType = new SqlCommand("select * from type", conn);

            SqlDataAdapter gt = new SqlDataAdapter(getType);

            DataTable type = new DataTable();

            gt.Fill(type);

            dataGridView1.DataSource = type;
        }
    }
}
