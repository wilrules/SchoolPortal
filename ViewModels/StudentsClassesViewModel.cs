using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModels
{
    public class StudentsClassesViewModel
    {
    
        public List<Student> Students { get; set; }

        public List<Year> Years { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}