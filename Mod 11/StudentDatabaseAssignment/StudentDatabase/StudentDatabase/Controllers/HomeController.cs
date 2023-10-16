using StudentDatabase.Models;
using StudentDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}