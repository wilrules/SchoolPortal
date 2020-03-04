using SchoolPortal.Models;
using SchoolPortal.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            var students = _context.Students.
            Include(y => y.Year).
            Include(g => g.Gender).ToList();
            return View(students);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var student = _context.Students.
            Include(y => y.Year).
            //Include(s => s.StudentAddress).
            Include(g => g.Gender).
            Include(r => r.Religion).
            Include(t => t.Tribe).
            Include(s => s.StudentsSubjects).
            SingleOrDefault(c => c.Id == id);

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
            }
            if (student.Id == 0)
                _context.Students.Add(student);
                _context.SaveChanges();

            return RedirectToAction("Index", "Student");

        }




       
          
        

        public ActionResult Edit(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if (student == null)

                return HttpNotFound();

            var viewmodel = new StudentFormViewModel
            {
                Student = student,
                Genders = _context.Genders.ToList(),
                Years = _context.Years.ToList(),
                Religions = _context.Religions.ToList(),
                Tribes = _context.Tribes.ToList()
            };
            return View("StudentEditForm", viewmodel);
        }


        [HttpPost]
        public ActionResult Edit (Student student)
        {
            if (ModelState.IsValid)
            {
                var studentInDb = _context.Students.Single(c => c.Id == student.Id);
                studentInDb.FirstName = student.FirstName;
                studentInDb.MiddleName = student.MiddleName;
                studentInDb.Lastname = student.Lastname;
                studentInDb.ReligionId = student.ReligionId;
                studentInDb.TribeId = student.TribeId;
                studentInDb.EnrolmentDate = student.EnrolmentDate;
                studentInDb.GenderId = student.GenderId;
                studentInDb.YearId = student.YearId;
                studentInDb.DateOfBirth = student.DateOfBirth;
                studentInDb.HouseNumberOrName = student.HouseNumberOrName;
                studentInDb.FirstLineofAdd = student.FirstLineofAdd;
                studentInDb.SecondLineofAdd = student.SecondLineofAdd;
                studentInDb.Area = student.Area;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
       



        // GET: Teachers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _context.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = _context.Students.Find(id);

            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}