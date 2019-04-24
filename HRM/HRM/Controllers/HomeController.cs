using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{

    
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var NumOfDepartment = db.Depts.Count();
            ViewBag.TotalDept = NumOfDepartment;


            var NumOfEmployee = db.Employees.Count();
            ViewBag.TotalEmployee = NumOfEmployee;


            var NumOfDesignation = db.Designations.Count();
            ViewBag.TotalDesignation = NumOfDesignation;


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