using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class Bell
    {

        public int BellID { get; set; }
        public TimeSpan LessonStartTime { get; set; }
        public TimeSpan LessonEndTime { get; set; }
    }
}
