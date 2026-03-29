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
    public partial class SportForm : Form
    {

        Conn dataBase = new Conn();

        public SportForm()
        {
            InitializeComponent();
        }

        private void SportForm_Load(object sender, EventArgs e)
        {
            Data();

        }

        private void Data()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getSport = new SqlCommand("select * from sport", conn);

            SqlDataAdapter gs = new SqlDataAdapter(getSport);

            DataTable sport = new DataTable();

            gs.Fill(sport);

            dataGridView1.DataSource = sport;
        }
    }
}
