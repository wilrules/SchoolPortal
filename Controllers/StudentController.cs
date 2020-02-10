using SchoolPortal.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.ViewModels;
using System.Data.Entity.Validation;

namespace SchoolPortal.Controllers
{
    public class StudentController : Controller
    {

        // DB context to access the database
        private ApplicationDbContext _context;
      

        //initializing the _context in a construtor
        public StudentController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }




       // GET: Student
        public ActionResult Index()
        {
            var students = _context.Students.Include(c =>c.Form).ToList();
            return View(students);
        }


        // GET: Details
        public ActionResult Details(int id)
        {


            var student = _context.Students.SingleOrDefault(c => c.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);

        }



        public ActionResult New()
        {
            var forms = _context.Forms.ToList();
            var viewmodel = new NewStudentViewModel
            {
                Form = forms
            };

            return View(viewmodel);
        }


        [HttpPost]
        public ActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index", "Student");



        }






    }
}