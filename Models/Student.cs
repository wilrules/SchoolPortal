using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        public IList<Subject> Subject { get; set; }




        public IList<Year> Year { get; set; }

        [Display(Name = "Class")]
        public byte YearId { get; set; }





        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Gender")]
        public byte GenderId { get; set; }
     
        public virtual StudentAddress StudentAddress { get; set; }

    }
}