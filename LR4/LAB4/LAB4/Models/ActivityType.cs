using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class ActivityType
    {

        public int ActivityTypeID { get; set; }
        public string ActivityTypeName { get; set; }
        public string ActivityTypesShortName { get; set; }

        public virtual ICollection<Classroom> Classrooms { get; set; }
    }
}
