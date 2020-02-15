using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModels
{
    public class NewStudentViewModel
    {
        
        public IEnumerable<Gender> Genders { get; set; }

        public Student Student { get; set; }

        public IEnumerable<Year> Years { get; set; }
    }
}