using Newtonsoft.Json;
using searching_data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using searching_data.Models;
using System.Web.Mvc;

namespace searching_data.Controllers
{
    public class imageController : Controller
    {
        socialnetworkEntities2 db = new socialnetworkEntities2();
        // GET: image
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult upload(post images)
        {
            string fileName = Path.GetFileNameWithoutExtension(images.ImageFile.FileName);
            string extension = Path.GetExtension(images.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
            images.media_path = "~/App_Data/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
            images.ImageFile.SaveAs(fileName);
            using (socialnetworkEntities2 db = new socialnetworkEntities2())
            {
                db.posts.Add(images);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View();
        }

    }
}
