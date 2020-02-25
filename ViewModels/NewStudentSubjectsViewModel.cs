using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModels
{
    public class NewStudentSubjectsViewModel
    {
        public IEnumerable<Student> Student { get; set; }

        public StudentsSubjects StudentsSubjects { get; set; }

        public IEnumerable<Subjects> Subjects { get; set; }

        public IEnumerable<Year> Years { get; set; }

      

       


    }
}