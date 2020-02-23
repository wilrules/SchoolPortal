using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    public class Student

    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Student's First Name")]
        [StringLength(12, ErrorMessage ="Maximum Length Of Characters Allowed Is 12")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(12, ErrorMessage = "Maximum Length Of Characters Allowed Is 12")]
        public string MiddleName { get; set;}

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Please Enter Student's Surname")]
        [StringLength(12, ErrorMessage = "Maximum Length Of Characters Allowed Is 12")]
        public string Lastname { get; set; }



        [Required(ErrorMessage = "Please Enter Student's Date Of Birth")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Student's Date Of Enrolment")]
        [Display(Name = "Date Of Enrolment")]
        public DateTime EnrolmentDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]



        //Rels
        public ICollection<StudentsSubjects> StudentsSubjects { get; set; }

        [Required]
        public virtual StudentAddress StudentAddress { get; set; }

        public int YearId { get; set; }
        public virtual Year Year { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }









       

    }
}