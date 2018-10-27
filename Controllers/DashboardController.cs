using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicWeb.Dal;
using System.Web.Mvc;
using System.Data;

namespace DynamicWeb.Controllers
{
    public class DashboardController : Controller
    {
        DashboardDAL obj = new DashboardDAL();
        // GET: Dashboard
        public ActionResult Dashboard()
        {
         DataTable dt =   obj.BindMenu();
           List<DashboardDAL> objmenulist = new List<DashboardDAL>();
            

            foreach (DataRow row in dt.Rows)
            {
                DashboardDAL objmenu = new DashboardDAL();
                objmenu.MenuName = row["menu_name"].ToString();
                objmenu.menu_path = row["menu_path"].ToString();
                objmenulist.Add(objmenu);
            }

            // ViewData.Model = dt.AsEnumerable();
            return View(objmenulist.ToList());
        }

        public ActionResult AdminDashboard()
        {
            return View();
        }
    }
}