using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SELORG.Models;
namespace SELORG.Controllers
{
    public class publicationsController : Controller
    {
        //
        // GET: /publications/


        /// <summary>
        /// CRUD operations for Megazine
        /// </summary>
        /// <returns></returns>

        public ActionResult addMegazine()
        {
            return View();
        }

        public bool add_Megazine()
        {
            return true;
        } 
       

        public ActionResult updateMegazine()
        {
            return View();
        }

        public bool update_Megazine()
        {
            return true;
        }




        public bool deleteMegazine(int id)
        {
            return true;
        }


        public ActionResult megazine()
        {
            return View();
        }







        /// <summary>
        /// CRUD operations for Directory
        /// </summary>
        /// <returns></returns>



        public ActionResult addDirectory()
        {
            return View();
        }
        public bool add_Directory()
        {
            return true;
        }


        public ActionResult updateDirectory()
        {
            return View();
        }

        public bool update_Directory()
        {
            return true;
        }


        public bool deleteDirectory(int id)
        {
            return true;
        }



        


        public ActionResult directory()
        {
            return View();
        }

        public ActionResult detail(int id)
        {
            return View();
        }

    }
}
