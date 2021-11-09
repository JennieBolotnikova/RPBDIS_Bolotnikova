using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
