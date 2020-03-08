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
        public IHttpActionResult GetStudent(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if (student == null)
            return NotFound();

            return Ok (Mapper.Map<Student, StudentDto>(student));
        }

        // PUT: api/Students/5
        [HttpPut]
        //[ResponseType(typeof(void))]
        public IHttpActionResult UpdateStudent(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = _context.Students.SingleOrDefault(s => s.Id == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            _context.SaveChanges();

            return Ok();

        }




        // POST: api/Students
        [HttpPost]
        //[ResponseType(typeof(Student))]
        public IHttpActionResult CreateStudent(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
             
            var student = Mapper.Map<StudentDto, Student>(studentDto);

            _context.Students.Add(student);
            _context.SaveChanges();


            studentDto.Id = student.Id;

            return Created(new Uri(Request.RequestUri + "/" + student.Id), studentDto);
        }


        [HttpDelete]
        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            var studentInDb = _context.Students.SingleOrDefault(s => s.Id == id);

            if (studentInDb == null)
                return NotFound();

            _context.Students.Remove(studentInDb);
            _context.SaveChanges();

            return Ok();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

     
    }
}