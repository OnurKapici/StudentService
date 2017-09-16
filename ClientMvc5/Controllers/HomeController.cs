using ClientMvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientMvc5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (StudentServices.StudentClient ServiceClient = new StudentServices.StudentClient())
            {
               

                
                ViewBag.Ogrenciler =  ServiceClient.GetStudents().ToList();

               return View();

            }
        }


        public ActionResult StudentCreate()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult StudentCreate(string FullName,string StudentNo, string ClassNo)
        {
            using (StudentServices.StudentClient ServiceClient = new StudentServices.StudentClient())
            {
                ServiceClient.AddStudent(FullName, StudentNo, ClassNo);

            }
            ViewBag.StudentCreate = "Öğrenci Kaydedildi";

                return View();
        }

        
        public ActionResult StudentDelete(int Id)
        {
            using (StudentServices.StudentClient ServiceClient = new StudentServices.StudentClient())
            {
                ServiceClient.DeleteStudent(Id);

            }
            ViewBag.StudentDelete = "Öğrenci Silindi";

            return RedirectToAction("Index");
        }

        public ActionResult StudentEdit(int Id)
        {
            using (StudentServices.StudentClient ServiceClient = new StudentServices.StudentClient())
            {
                ServiceClient.EditStudent(Id);

            }
            ViewBag.StudentEdit = "Öğrenci Düzenlendi";

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