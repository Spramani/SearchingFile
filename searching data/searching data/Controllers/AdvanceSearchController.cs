using Newtonsoft.Json;
using searching_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace searching_data.Controllers
{
    
    public class AdvanceSearchController : Controller
    {
        socialnetworkEntities2 db = new socialnetworkEntities2();
        // GET: AdvanceSearch
        public ActionResult Index()
        {
            return View(db.users.ToList());
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