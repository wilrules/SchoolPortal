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
using AutoMapper;
using SchoolPortal.Dtos;
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
        public IEnumerable<StudentDto> GetStudents()
        {
            return _context.Students.ToList().Select(Mapper.Map<Student, StudentDto>);
        }


        // GET: api/Students/5
        //[ResponseType(typeof(Student))]
        public StudentDto GetStudent(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
         
            if (student == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<Student, StudentDto>(student);
        }

        // PUT: api/Students/5
        [HttpPut]
        //[ResponseType(typeof(void))]
        public void UpdateStudent(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }

            var studentInDb = _context.Students.SingleOrDefault(s => s.Id == id);

            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(studentDto, studentInDb);

           

            _context.SaveChanges();

        }




        // POST: api/Students
        [HttpPost]
        //[ResponseType(typeof(Student))]
        public StudentDto CreateStudent(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var student = Mapper.Map<StudentDto, Student>(studentDto);

            _context.Students.Add(student);
            _context.SaveChanges();


            studentDto.Id = student.Id;

            return studentDto;
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