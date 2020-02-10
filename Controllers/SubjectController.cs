using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolPortal.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Movie
        public ActionResult Index() 
        {

            var subject = new Subject() { Name = "Maths" };
            return View(subject);
        }
    }
}