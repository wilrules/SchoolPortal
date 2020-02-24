using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Models;

namespace SchoolPortal.Controllers
{
    public class StudentsSubjectsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentsSubjects
        public ActionResult Index()
        {
            var studentsSubjects = db.StudentsSubjects.Include(s => s.Student).Include(s => s.Subjects).Include(s => s.Year);
            return View(studentsSubjects.ToList());
        }

        // GET: StudentsSubjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsSubjects studentsSubjects = db.StudentsSubjects.Find(id);
            if (studentsSubjects == null)
            {
                return HttpNotFound();
            }
            return View(studentsSubjects);
        }

        // GET: StudentsSubjects/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName");
            ViewBag.SubjectsId = new SelectList(db.Subjects, "SubjectsId", "SubjectName");
            ViewBag.YearId = new SelectList(db.Years, "YearId", "YearName");
            return View();
        }

        // POST: StudentsSubjects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Scores,StudentId,YearId,SubjectsId")] StudentsSubjects studentsSubjects)
        {
            if (ModelState.IsValid)
            {
                db.StudentsSubjects.Add(studentsSubjects);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", studentsSubjects.StudentId);
            ViewBag.SubjectsId = new SelectList(db.Subjects, "SubjectsId", "SubjectName", studentsSubjects.SubjectsId);
            ViewBag.YearId = new SelectList(db.Years, "YearId", "YearName", studentsSubjects.YearId);
            return View(studentsSubjects);
        }

        // GET: StudentsSubjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsSubjects studentsSubjects = db.StudentsSubjects.Find(id);
            if (studentsSubjects == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", studentsSubjects.StudentId);
            ViewBag.SubjectsId = new SelectList(db.Subjects, "SubjectsId", "SubjectName", studentsSubjects.SubjectsId);
            ViewBag.YearId = new SelectList(db.Years, "YearId", "YearName", studentsSubjects.YearId);
            return View(studentsSubjects);
        }

        // POST: StudentsSubjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Scores,StudentId,YearId,SubjectsId")] StudentsSubjects studentsSubjects)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentsSubjects).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", studentsSubjects.StudentId);
            ViewBag.SubjectsId = new SelectList(db.Subjects, "SubjectsId", "SubjectName", studentsSubjects.SubjectsId);
            ViewBag.YearId = new SelectList(db.Years, "YearId", "YearName", studentsSubjects.YearId);
            return View(studentsSubjects);
        }

        // GET: StudentsSubjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsSubjects studentsSubjects = db.StudentsSubjects.Find(id);
            if (studentsSubjects == null)
            {
                return HttpNotFound();
            }
            return View(studentsSubjects);
        }

        // POST: StudentsSubjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentsSubjects studentsSubjects = db.StudentsSubjects.Find(id);
            db.StudentsSubjects.Remove(studentsSubjects);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
