using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    public class Year
    {


        public int YearId { get; set; }

        public int YearNumber { get; set; }

        [Display(Name = "Class")]   
        public string YearName { get; set; }

        public Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<StudentsSubjects> StudentSubjects { get; set; }

       


        


    }
}