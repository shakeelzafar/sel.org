using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sel.org.pk.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult index()
        {
            return View();
        }

        //
        public ActionResult contact_us()
        {
            return View();
        }


        //
        public ActionResult introduction()
        {
            return View();
        }

    }
}
