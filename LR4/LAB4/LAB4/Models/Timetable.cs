using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Models
{
    public class Timetable
    {
   

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int DayID { get; set; }
        public int LessonID { get; set; }
        public int DisciplineID { get; set; }
        public int ActivityTypeID { get; set; }
        public int GroupID { get; set; }
        public int TeacherID { get; set; }
        public int ClassroomID { get; set; }
    }
}
