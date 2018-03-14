using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SELORG.Controllers
{
    public class searchController : Controller
    {
        //
        // GET: /search/


        //Return the posts/News
        public ActionResult search(String searchString)
        {
            return View();
        }

    }
}
