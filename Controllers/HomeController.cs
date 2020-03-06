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

        public ActionResult New()
        {

            return View();
        }





        [HttpPost]
        public ActionResult Create(Home home, HttpPostedFileBase upload)
        {
            if (home.HomeId == 0 && upload != null && upload.ContentLength > 0)
            {
                var schoolPicture = new File
                {
                    FileName = System.IO.Path.GetFileName(upload.FileName),
                    FileType = FileType.SchoolPicture,
                    ContentType = upload.ContentType
                };
                using (var reader = new System.IO.BinaryReader(upload.InputStream))
                {
                    schoolPicture.Content = reader.ReadBytes(upload.ContentLength);
                }
                home.Files = new List<File> { schoolPicture };

            }
            _context.Homes.Add(home);
            _context.SaveChanges();
            return RedirectToAction("Welcome" , "Home");

        }
       
    }
}