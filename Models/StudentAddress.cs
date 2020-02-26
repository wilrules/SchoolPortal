using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    public class StudentAddress
    {
        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }

        [Required]
        [Display(Name = "House Name or House Number")]
        public string HouseNumberOrName { get; set; }

        [Required]
        [Display(Name = "First Line Of Address")]
        public string FirstLineofAdd { get; set; }

        [Required]
        [Display(Name = "Second Line Of Address")]
        public string SecondLineofAdd { get; set; }

        [Required]
        public string Area { get; set; }

        public virtual Student Student { get; set; }
    }
}