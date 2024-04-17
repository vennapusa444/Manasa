using ABCHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCHospital.Controllers
{
    public class HomeController : Controller
    {


        //http://localhost:54061/Home/Index
        public ActionResult Index()
        {
            //wwill render view(.cshtml) and form viewresult-->browser
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


        public ActionResult GetScore(string team)
        {
            // ViewBag.Score = 351;
            ViewData["score"] = 351;
            return View();
        }

        public ActionResult GetDetails()
        {
            //Name ,age,bg




           Patient patient = new Patient();
            patient.Name = "Ajay";
            patient.age = 22;
            patient.bg = "A+ve";
            ViewBag.Score = 351;
            return View(patient);



        }
    }
}