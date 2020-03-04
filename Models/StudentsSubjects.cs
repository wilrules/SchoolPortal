using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class StudentsSubjects
    {
        public int Id { get; set; }

        public int? Scores { get; set;}

        //[ForeignKey("Student")]
        [Display(Name = "Student Name")]
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }


        [Display(Name = "Class")]
        public int? YearId { get; set; }
        public virtual Year Year { get; set; }


        [Display(Name = "Subject")]
        public int? SubjectsId { get; set; }
        public virtual Subjects Subjects { get; set; }













    }
}