using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Subjects
    {
        public int SubjectsId { get; set; }

        [Display(Name = "Subject's Name")]
        [StringLength(12, ErrorMessage = "Maximum Length Of Characters Allowed Is 15")]
        [Required(ErrorMessage = "Please Enter Subject's Name")]
        public string SubjectName { get; set; }

        [Display(Name = "Pass Mark")]
        [Required(ErrorMessage = "Please Enter Subject's Pass Mark")]
        public int? PassMark { get; set; }


        //Rels
        public virtual ICollection<StudentsSubjects> StudentsSubjects { get; set; }




        // Used for viewmodel NewSubjectViewModel
        [Display(Name = "Class")]
        [Required(ErrorMessage = "Please Assign Subject To A Class")]
        public int YearId { get; set; }
        public virtual ICollection<Year> Years { get; set; }








    }
}