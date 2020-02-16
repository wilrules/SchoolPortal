using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Teacher
    {
        [ForeignKey("Year")]
        [Display(Name = "Class")]
        public int TeacherId { get; set; }

        [Display(Name ="Title")]
        public string Title { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Class")]
        public Year Year { get; set; }
    }
}