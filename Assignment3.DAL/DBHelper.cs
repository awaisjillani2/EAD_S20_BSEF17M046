using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment3.DAL
{
    internal class DBHelper : IDisposable
    {
        String _connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        MySqlConnection _conn = null;
        public DBHelper()
        {
            _conn = new MySqlConnection(_connStr);
            _conn.Open();
        }

        public int ExecuteNonQuery(String query)
        {
            MySqlCommand command = new MySqlCommand(query, _conn);
            var count = command.ExecuteNonQuery();
            return count;
        }

        public int ExecuteQuery(String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, _conn);
            var count = command.ExecuteNonQuery();
            return count;
        }
        public Object ExecuteScalar(String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, _conn);
            return command.ExecuteScalar();
        }

        public MySqlDataReader ExecuteReader(String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, _conn);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
        }
    }
}
