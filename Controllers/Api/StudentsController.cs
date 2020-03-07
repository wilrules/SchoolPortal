using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SchoolPortal.Models;

namespace SchoolPortal.Controllers.Api
{
    public class StudentsController : ApiController
    {
        private ApplicationDbContext   _context  ;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Students
        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }


        // GET: api/Students/5
        //[ResponseType(typeof(Student))]
        public Student GetStudent(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
         
            if (student == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return student;
        }

        // PUT: api/Students/5
        [HttpPut]
        //[ResponseType(typeof(void))]
        public void UpdateStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }

            var studentInDb = _context.Students.SingleOrDefault(s => s.Id == id);

            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

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
            studentInDb.FileId = student.FileId;

            _context.SaveChanges();

        }




        // POST: api/Students
        [HttpPost]
        //[ResponseType(typeof(Student))]
        public Student CreateStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.Students.Add(student);
            _context.SaveChanges();

            return student;
        }

        [HttpDelete]
        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public void DeleteStudent(int id)
        {
            var studentInDb = _context.Students.SingleOrDefault(s => s.Id == id);

            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Students.Remove(studentInDb);
            _context.SaveChanges();
     
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Count(e => e.Id == id) > 0;
        }
    }
}