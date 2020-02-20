using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SchoolPortal.ViewModels
{
    public class NewSubjectViewModel
    {
        public IEnumerable<Year> Years { get; set; }

        public Subjects Subjects { get; set; }

    }
}