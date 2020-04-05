using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2.DAL
{
    internal class DBHelper : IDisposable
    {
        String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amir\source\repos\Assignment2\Assignment2.mdf;Integrated Security = True";
        SqlConnection con = null;

        public DBHelper()
        {
            con = new SqlConnection(conStr);
            con.Open();
        }

        public int ExecuteNonQuery(String query)
        {
            SqlCommand command = new SqlCommand(query, con);
            var count = command.ExecuteNonQuery();
            return count;
        }

        public Object ExecuteScalar(String query)
        {
            SqlCommand command = new SqlCommand(query, con);
            return command.ExecuteScalar();
        }

        public SqlDataReader ExecuteReader(String query)
        {
            SqlCommand command = new SqlCommand(query, con);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}