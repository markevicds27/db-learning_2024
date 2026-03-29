using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBKozlovskiy
{
    internal class Connection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-21MMBAU;Initial Catalog=DBKozlovskiy;Integrated Security=True;Encrypt=False");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
