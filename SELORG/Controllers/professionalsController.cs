using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SELORG.Models;

namespace SELORG.Controllers
{
    public class professionalsController : Controller
    {
        //
        // GET: /professionals/

        public ActionResult addprofessional()
        {
            return View();
        }
        public ActionResult findprofessional()
        {
            return View();
        }

        public ActionResult librarian(String librarianData)
        {
            return View();
        }

    }
}
