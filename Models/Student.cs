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
    
        [StringLength(12)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }


        [Display(Name = "Last Name")]
        [StringLength(12)]
        [Required]
        public string Lastname { get; set; }


        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ? DateOfBirth { get; set; }


        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        [Display(Name = "Student Type")]
        public string Type { get; set; }


        public Subject Subject { get; set; }


        [Display(Name = "Student's Class")]
        public Form Form { get; set; }



















    }
}