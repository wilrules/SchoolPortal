using SchoolPortal.Models;
using SchoolPortal.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

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

        //// GET: Student
        public ActionResult Index()
        {
            var students = _context.Students.Include(y => y.Year).ToList();
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
            var religion = _context.Religions.ToList();
            var tribe = _context.Tribes.ToList();

            var viewmodel = new StudentFormViewModel
            {
                Genders = genders,
                Years = years,
                Religions = religion,
                Tribes = tribe
               
            };

            return View("StudentForm", viewmodel);
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new StudentFormViewModel
                {
                    Student = student,
                    Genders = _context.Genders.ToList(),
                    Years = _context.Years.ToList(),
                    Tribes = _context.Tribes.ToList(),
                    Religions = _context.Religions.ToList()
                };
                return View("StudentForm", viewModel);
            };

            if (student.Id == 0)

                _context.Students.Add(student);
                _context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }

        public ActionResult Edit(int? id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if (student == null)
            {
                return HttpNotFound();
            }

            var viewmodel = new StudentFormViewModel
            {
                Student = student,
                Genders = _context.Genders.ToList(),
                Years = _context.Years.ToList()
            };

            return View("StudentForm", viewmodel);
        }
    }
}