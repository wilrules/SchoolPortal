using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Subjects
    {
        public int SubjectsId { get; set; }

        public string SubjectName { get; set; } 

        public int? PassMark { get; set; }


        //Rels
        public virtual ICollection<StudentsSubjects> StudentsSubjects { get; set; }




        // Used for viewmodel NewSubjectViewModel
        public int YearId { get; set; } 
        public virtual ICollection<Year> Years { get; set; }








    }
}