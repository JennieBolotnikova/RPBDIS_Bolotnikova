using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class Classroom
    {
        public int ClassroomID { get; set; }
        public int ClassroomNumber { get; set; }
        public int BuildingID { get; set; }
        public int NumberOfSeats { get; set; }

        public int ActivityTypeID { get; set; }

        public virtual Building Building { get; set; }
        public virtual ActivityType ActivityType { get; set; }
    }
}
