using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModels
{
    public class NewStudentViewModel
    {
        public IEnumerable<Form> Form { get; set; }
        public Student Student { get; set; }
    }
}