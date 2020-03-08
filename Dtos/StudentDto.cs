using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Student's First Name")]
        [StringLength(12, ErrorMessage = "Maximum Length Of Characters Allowed Is 12")]
        public string FirstName { get; set; }

        [StringLength(12, ErrorMessage = "Maximum Length Of Characters Allowed Is 12")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please Enter Student's Surname")]
        [StringLength(12, ErrorMessage = "Maximum Length Of Characters Allowed Is 12")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please Enter Student's Date Of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Student's Date Of Enrolment")]
        public DateTime EnrolmentDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public string HouseNumberOrName { get; set; }

        [Required]
        public string FirstLineofAdd { get; set; }

        [Required]
        public string SecondLineofAdd { get; set; }

        [Required]
        public string Area { get; set; }

        //public ICollection<StudentsSubjects> StudentsSubjects { get; set; }

       
        public int FileId { get; set; }

        //public virtual ICollection<File> Files { get; set; }

        public int ReligionId { get; set; }
        //public virtual Religion Religion { get; set; }

        public int TribeId { get; set; }
       // public virtual Tribe Tribe { get; set; }

        public int YearId { get; set; }
       //public virtual Year Year { get; set; }

        public int GenderId { get; set; }
      //public Gender Gender { get; set; }

        public int? TeacherId { get; set; }
      //public virtual Teacher Teacher { get; set; }
    }
}