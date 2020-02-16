using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Teacher
    {
        [ForeignKey("Year")]
        public int TeacherId { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }    

        public Year Year { get; set; }
    }
}