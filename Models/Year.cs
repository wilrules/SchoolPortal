using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.Models
{
    public class Year
    {
        public int YearId { get; set; }

        public int YearNumber { get; set; }

        [Display(Name = "Class")]   
        public string YearName { get; set; }

        public Teacher Teacher { get; set; }

       
    }
}