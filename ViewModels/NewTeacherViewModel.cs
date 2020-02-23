using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModels
{
    public class NewTeacherViewModel
    {
        public Teacher Teacher { get; set; }

        public IEnumerable <Title> Titles  { get; set; }

        public IEnumerable <Year> Years { get; set; }


    }
}