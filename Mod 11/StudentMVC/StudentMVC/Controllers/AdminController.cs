using StudentMVC.Models;
using StudentMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (StudentdbEntities db = new StudentdbEntities())
            {
                var Additions = db.Student_Information.Where(x => x.Removed == null).ToList();
                var studentVms = new List<StudentAddVm>();
                foreach (var AddStudent in Additions)
                {
                    var StudentVm = new StudentAddVm();
                    StudentVm.Id = AddStudent.Id;
                    StudentVm.FirstName = AddStudent.FirstName;
                    StudentVm.LastName = AddStudent.LastName;
                    StudentVm.Age = AddStudent.Age;
                    studentVms.Add(StudentVm);
                }
                return View(studentVms);
            }
        }

        public ActionResult RemoveStudent(int Id)
        {
            using (StudentdbEntities db = new StudentdbEntities())
            {
                var StudentId = db.Student_Information.Find(Id);
                StudentId.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}