using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Entities;
using Assignment3.DAL;

namespace Assignment3.BAL
{
    public static class FolderBO
    {
        public static int SaveFolder(FolderDTO dto)
        {
            return FolderDAO.SaveFolder(dto);
        }

        public static List<FolderDTO> GetFolders(int pId)
        {
            return FolderDAO.GetFolders(pId);
        }
    }
}
