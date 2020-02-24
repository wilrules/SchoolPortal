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
    
        public int TeacherId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        //relationship Navigation Properties for viewmodels

        public int YearId { get; set; }
        public virtual Year Year { get; set; }

        public int TitleId { get; set; }
        public virtual Title Title { get; set; }

    }
}