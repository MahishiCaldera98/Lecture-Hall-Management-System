using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment
{
    public class ConnectDb
    {
        public SqlConnection _connection;
        public SqlConnection GetConnection()
        {
            _connection = new SqlConnection(@"Data Source=KESHAN-WORKSPAC\SQLEXPRESS;Initial Catalog=project_999; Integrated Security=True");

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Open();
            }
            else
            {
                _connection.Open();
            }

            return _connection;
        }

        public void CloseConnection()
        {
            if(_connection != null)
                _connection.Close();
        }
    }
}
