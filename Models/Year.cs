using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Year
    {
        public int YearId { get; set; }

        public int YearNumber { get; set; }

        [Display(Name = "Class")]
        public string YearName { get; set; }

        public IList<Student> Student { get; set; }

       
        public Teacher Teacher { get; set; }
    }
}