using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.DAL
{
    public static class AdminDAO
    {
        public static Boolean validateAdmin(String adminLogin, String adminPassword)
        {
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    String query;
                    query = String.Format("Select count(*) from dbo.Admin where AdminLogin='{0}' and AdminPassword = '{1}'", adminLogin, adminPassword);
                    var id = (int)helper.ExecuteScalar(query);
                    if (id == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable getUserData()
        {
            using (DBHelper helper = new DBHelper())
            {
                DataTable table = new DataTable("User");
                DataColumn columnID = new DataColumn("UserID", typeof(System.Int32));
                table.Columns.Add(columnID);
                DataColumn columnName = new DataColumn("UserName", typeof(System.String));
                table.Columns.Add(columnName);
                DataColumn columnLogin = new DataColumn("UserLogin", typeof(System.String));
                table.Columns.Add(columnLogin);
                DataColumn columnAddress = new DataColumn("UserAddress", typeof(System.String));
                table.Columns.Add(columnAddress);
                DataColumn columnAge = new DataColumn("UserAge", typeof(System.Int32));
                table.Columns.Add(columnAge);
                String query;
                query = "Select UserID, UserName, UserLogin, UserAddress, UserAge from dbo.Users";
                var reader = helper.ExecuteReader(query);
                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    row["UserID"] = reader.GetInt32(0);
                    row["UserName"] = reader.GetString(1);
                    row["UserLogin"] = reader.GetString(2);
                    row["UserAddress"] = reader.GetString(3);
                    row["UserAge"] = reader.GetInt32(4);
                    table.Rows.Add(row);
                }
                return table;
            }
        }
    }
}