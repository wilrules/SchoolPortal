using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModels
{
    public class StudentFormViewModel
    {
        
        public IEnumerable<Gender> Genders { get; set; }

        public Student Student { get; set; }

        public File File { get; set; }

        public IEnumerable<Year> Years { get; set; }

        public IEnumerable<Religion> Religions { get; set; }

        public IEnumerable<Tribe> Tribes { get; set; }
    }
}