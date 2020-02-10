using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Student

    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "First Name")]
        [StringLength(12)]
        public string FirstName { get; set; }


        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }


        [Display(Name = "Surname")]
        [StringLength(12)]
        [Required]
        public string Lastname { get; set; }


        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        [Display(Name = "Type")]
        public string Type { get; set; }


        public Subject Subject { get; set; }

      
        public Form Form { get; set; }



















    }
}