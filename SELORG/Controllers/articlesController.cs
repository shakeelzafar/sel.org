using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SELORG.Controllers
{
    public class articlesController : Controller
    {
        //
        // GET: /articales/
        public ActionResult addNews()
        {
            return View();
        }

        public bool add_News()
        {
            return true;
        }


        public ActionResult updateNews()
        {
            return View();
        }

        public bool update_News()
        {
            return true;
        }

        public bool deleteNews(int id)
        {
            return true;
        }

 



        public ActionResult englishNews()
        {
            return View();
        }

        public ActionResult urduNews()
        {
            return View();
        }

        public ActionResult videos()
        {
            return View();
        }

        public ActionResult detail_of_news(int id)
        {
            return View();
        }
        
    }
}
