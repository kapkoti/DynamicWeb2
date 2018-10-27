using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicWeb.Dal;

namespace DynamicWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        UserRegistrationDAL objdal = new UserRegistrationDAL();
        public ActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult submitlogin(string username, string pwd)
        {
            objdal.Checkuser(pwd, username);
            return RedirectToAction("Dashboard", "Dashboard");          

        }
    }
}