using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolPortal.Controllers
{
    public class HomeController : Controller
    {
        // DB context to access the database
        private ApplicationDbContext _context;

        //initializing the _context in a construtor
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {


           
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