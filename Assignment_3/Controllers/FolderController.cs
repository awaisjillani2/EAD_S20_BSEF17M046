using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Entities;
using Assignment3.BAL;
using Assignment_3.Security;

namespace Assignment_3.Controllers
{
    public class FolderController : Controller
    {
        // GET: Folder
        [HttpPost]
        public JsonResult SaveFolder(FolderDTO dto)
        {
            var result = FolderBO.SaveFolder(dto);
            var d = new
            {
                res = result
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetFolders(int pId)
        {
            var result = FolderBO.GetFolders(pId);
            var d = new
            {
                res = result
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            SessionManager.ClearSession();
            return Redirect("~/User/Login");

        }
    }
}