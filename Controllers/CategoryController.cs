using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using DynamicWeb.Dal;

namespace DynamicWeb.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Category()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryDal obj)
        {
            CategoryDal objcat = new CategoryDal();
            objcat.AddCategory(obj.Categoryname);

            return Json(obj,JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult ShowCategoryList()
        {
            CategoryDal objcat = new CategoryDal();
            DataTable dt =   objcat.ShowCategory();
            List<CategoryDal> objmenulist = new List<CategoryDal>();


            foreach (DataRow row in dt.Rows)
            {
                CategoryDal objmenu = new CategoryDal();
                objmenu.Categoryname = row["cat_name"].ToString();
         
                objmenulist.Add(objmenu);
            }


            return Json(objmenulist , JsonRequestBehavior.AllowGet);
        }
    }
}