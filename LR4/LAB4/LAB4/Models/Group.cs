using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class Group
    {

        public int GroupID { get; set; }

        public string GroupName { get; set; }
        public int GroupNumber { get; set; }
        public int FacultyID { get; set; }
        public int NumberOfStudents { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
