using StudentMVC.Models;
using StudentMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(string FirstName, string LastName, string Age)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Age))
            {
                return View("~/View/Shared/Error.cshtml");
            }
            else
            {
                using (StudentdbEntities db = new StudentdbEntities())
                {
                    var AddingStudent = new AddStudent();
                    AddingStudent.FirstName = FirstName;
                    AddingStudent.LastName = LastName;
                    AddingStudent.Age = Age;

                    db.Student_Information.Add(AddingStudent);
                    db.SaveChanges();
                }
                return View("Success");
            }

        }
    }
}