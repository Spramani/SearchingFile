using searching_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace searching_data.Controllers
{
    public class HomeController : Controller
    {
        socialnetworkEntities db = new socialnetworkEntities();
        public ActionResult Index(string searching)
        {
            return View(db.users.Where(x => x.user_name_id.Contains(searching) || searching == null).ToList());
        }

       
    }
}