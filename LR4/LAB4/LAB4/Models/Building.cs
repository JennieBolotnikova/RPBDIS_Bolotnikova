using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class Building
    {
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }

        public virtual ICollection<Classroom> Classrooms { get; set; }
    }
}
