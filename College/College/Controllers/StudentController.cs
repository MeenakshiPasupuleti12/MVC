using College.Models;
using College.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace College.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            Student st = new Student()
            {
                StudentId = 9001,
                StudentName = "John",
                Standard = "10th",
                NameOfTheExam = "Final",
                s1 = 50,
                s2 = 46,
                s3 = 39,
                s4 = 67,
                s5 = 9,
                s6 = 60

            };
            StudentVM svm=new StudentVM(st);
            return View(svm);
        }
    }
}