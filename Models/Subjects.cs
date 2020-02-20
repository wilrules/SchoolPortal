using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Subjects
    {
        public int SubjectsId { get; set; }

        public string SubjectName { get; set; } 

        public int? PassMark { get; set; }
        
        public StudentsSubjects StudentsSubjects { get; set;}

     

        public Year Year { get; set; }

    }
}