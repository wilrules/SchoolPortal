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
            var students = _context.Students.Include(c => c.Gender).Include(y =>y.Year).ToList();
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

            var genders = _context.Genders.ToList();
            var years = _context.Years.ToList();
            var viewmodel = new NewStudentViewModel
        {
            Genders = genders,
            Years = years
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