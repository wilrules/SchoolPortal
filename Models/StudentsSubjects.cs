using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class StudentsSubjects
    {
        public int Id { get; set; }

        public string Name  { get; set; }

        public int? Scores { get; set;}

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int YearId { get; set; }

        public Year Year { get; set; }


    }
}