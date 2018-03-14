using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SELORG.Models;

namespace SELORG.Controllers
{
    public class usersController : Controller
    {
        //
        // GET: /users/

        selorgpkEntities ctx = new selorgpkEntities();

        public bool AddUserProfile(UserProfile user)
        {
            //Add user to db
            return true;
        }
        public bool UpdateUserProfile(UserProfile user)
        {
            //User user to db
            return true;
        }
        public bool DeleteUserProfile(UserProfile user)
        {
            //User user to db
            return true;
        }







        public ActionResult forget()
        {
            return View();
        }


        public ActionResult SubmitEmail(String email)
        {
            return View();
        }

        public ActionResult signup(String Name, String email, String Password)
        {
            return View();
        }

        public ActionResult login(String email, String Password)
        {
            return View();
        }

        public ActionResult updatepassword()
        {
            return View();

        }

        public ActionResult updateuser(String Password)
        {
            return View();

        }
    }
}
