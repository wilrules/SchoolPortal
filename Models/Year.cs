using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Year
    {

        public int YearId { get; set; }

        public int YearNumber { get; set; }

        public string YearName { get; set; }

        public IList<Student> Student { get; set; }
    }
}