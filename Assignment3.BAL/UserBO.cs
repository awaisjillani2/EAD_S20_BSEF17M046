using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.DAL;
using Assignment3.Entities;

namespace Assignment3.BAL
{
    public static class UserBO
    {
        public static int SaveUser(UserDTO dto)
        {
            return UserDAO.SaveUser(dto);
        }

        public static UserDTO ValidateUser(String login, String password)
        {
            return UserDAO.ValidateUser(login, password);
        }
    }
}
