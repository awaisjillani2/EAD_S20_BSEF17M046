using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Entities;
using MySql.Data.MySqlClient;

namespace Assignment3.DAL
{
    public static class FolderDAO
    {
        public static int SaveFolder(FolderDTO dto)
        {
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    String query = String.Format("insert into folder (FolderName, ParentFolderID) values('{0}','{1}')", dto.fName, dto.pId);
                    var result = helper.ExecuteNonQuery(query);
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static List<FolderDTO> GetFolders(int pId)
        {
            List<FolderDTO> list = new List<FolderDTO>();
            FolderDTO dto = null;
            try
            {
                using (DBHelper helper = new DBHelper())
                {
                    String query;
                    query = String.Format("Select * from folder where ParentFolderID='{0}'", pId);
                    MySqlDataReader reader = helper.ExecuteReader(query);
                    while (reader.Read())
                    {
                        dto = new FolderDTO();
                        dto.fName = (String)reader["fName"];
                        dto.fId = (int)reader["fId"];
                        dto.pId = (int)reader["pId"];
                        list.Add(dto);
                    }
                    return list;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return list;
            }

        }
    }
}
