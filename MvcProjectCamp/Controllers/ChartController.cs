
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;
using MvcProjectCamp.Models;

namespace MvcProjectCamp.Controllers
{
    public class ChartController : Controller
    {
        public ActionResult Chart1()
        {
            return View();
        }

        public ActionResult CategoryChart() 
        {
            return Json(CategoryList(), JsonRequestBehavior.AllowGet);
        }
        public List<CategoryClass> CategoryList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Seyahat",
                CategoryCount = 7
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Film",
                CategoryCount = 4
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kitap",
                CategoryCount = 2
            });
            return ct;
        }
    }
}