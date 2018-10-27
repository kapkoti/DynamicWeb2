using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicWeb.Models;
using DynamicWeb.Dal;

namespace DynamicWeb.Controllers
{
    public class UserRegistrationController : Controller
    {
        UserModelBinder objbinder = new UserModelBinder();
        UserRegistrationDAL objregistration = new UserRegistrationDAL();
        

        // GET: UserRegistration
        public ActionResult UserRegistration()
        {
         
            return View();
        }

        public ActionResult Submit([ModelBinder(typeof(UserModelBinder))]UserRegistrationModel objuserregistration)
        {
            objregistration.registerUser(objuserregistration.name, objuserregistration.phone, objuserregistration.email, objuserregistration.userName, objuserregistration.password);
            return View("");
        }
    }
}