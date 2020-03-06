using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    public class Home
    {
        public int HomeId { get; set; }

        public string Name { get; set; }


        public int FileId { get; set; }
        public virtual ICollection<File> Files { get; set; }

    }
}