using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Assignment3.Entities;

namespace Assignment3.DAL
{
    public static class UserDAO
    {
        public static UserDTO ValidateUser(String login, String password)
        {
            UserDTO dto = null;
            try
            {
                using (DBHelper helper = new DBHelper())
                {

                    String query;
                    query = String.Format("Select name from user where Login='{0}' and Password='{1}'", login, password);
                    var name = Convert.ToString(helper.ExecuteScalar(query));
                    if (name != "")
                    {
                        dto = new UserDTO();
                        dto.name = name;
                        dto.login = login;
                        dto.password = password;
                        return dto;
                    }
                    return dto;
                }
            }
            catch (Exception)
            {
                return dto;
            }
        }


        public static int SaveUser(UserDTO dto)
        {
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    String query;
                    query = String.Format("Select count(*) from user where Login='{0}'", dto.login);
                    
                    var result = Convert.ToInt32(helper.ExecuteScalar(query));
                    if (result == 1)
                    {
                        return -1;
                    }
                    else
                    {
                        query = String.Format("insert into user (Login, Name, Password) values('{0}','{1}','{2}')", dto.login, dto.name, dto.password);
                        result = helper.ExecuteNonQuery(query);
                        if ((int)result == 1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
    }
}
