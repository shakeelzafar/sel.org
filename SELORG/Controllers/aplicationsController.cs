using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SELORG.Controllers
{
    public class applicationsController : Controller
    {
        //
        // GET: /aaplications/

        /// <summary>
        /// CRUD operations for Software
        /// </summary>
        /// <returns></returns>

        public ActionResult addSoftware()
        {
            return View();
        }

        public bool add_Software()
        {
            return true;
        }


        public ActionResult updateSoftware()
        {
            return View();
        }

        public bool update_Software()
        {
            return true;
        }




        public bool deleteSoftware(int id)
        {
            return true;
        }

 




        /// <summary>
        /// CRUD operations for Services
        /// </summary>
        /// <returns></returns>



        public ActionResult addServices()
        {
            return View();
        }
        public bool add_Services()
        {
            return true;
        }


        public ActionResult updateServices()
        {
            return View();
        }

        public bool update_Services()
        {
            return true;
        }


        public bool deleteServices(int id)
        {
            return true;
        }


 
        public ActionResult detail(int id)
        {
            return View();
        }




        public ActionResult softwares()
        {
            return View();
        }
        public ActionResult services()
        {
            return View();
        }

    }
}
