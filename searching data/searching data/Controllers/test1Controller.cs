using Newtonsoft.Json;
using searching_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace searching_data.Controllers
{
    public class test1Controller : Controller
    {
        socialnetworkEntities2 db = new socialnetworkEntities2();

        // GET: test1
        public ActionResult Index()
        {
            return View();
        }

        public string search_porduct(string s_text)
        {
            var porlist = (from p in db.users where p.user_name_id.Contains(s_text) select p).ToList();

            ViewBag.search_r = porlist;

            string sJSONResponse = JsonConvert.SerializeObject(porlist);

            return sJSONResponse;
        }

    }
}