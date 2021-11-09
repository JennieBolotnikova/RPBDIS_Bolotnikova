using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Models;

namespace LAB4.Data
{
    public class DbInitializer
    {
        public static void Initialize(TimetableContext db)
        {
            db.Database.EnsureCreated();

            Random randObj = new Random(1);

            //Заполнение таблицы тип занятия
            db.ActivityTypes.Add(new ActivityType {  ActivityTypeName = "Лекция", ActivityTypesShortName = "ЛК" });
            db.ActivityTypes.Add(new ActivityType {  ActivityTypeName = "Лабораторное занятие", ActivityTypesShortName = "ЛЗ" });
            db.ActivityTypes.Add(new ActivityType {  ActivityTypeName = "Практическое заняти", ActivityTypesShortName = "ПЗ" });
            db.SaveChanges();

            //Заполнение таблицы расписание звонков
            db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(8, 20, 0), LessonEndTime = new TimeSpan(9, 45, 0) });
            db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(10, 0, 0), LessonEndTime = new TimeSpan(11, 25, 0) });
            db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(11, 35, 0), LessonEndTime = new TimeSpan(13, 0, 0) });
            db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(13, 30, 0), LessonEndTime = new TimeSpan(14, 55, 0) });
            db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(15, 5, 0), LessonEndTime = new TimeSpan(16, 30, 0) });
            db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(16, 45, 0), LessonEndTime = new TimeSpan(18, 10, 0) });
            db.SaveChanges();

            //Заполнение таблицы корпуса
            db.Buildings.Add(new Building {BuildingName = "Первый корпус" });
            db.Buildings.Add(new Building {BuildingName = "Первый корпус" });
            db.SaveChanges();

            //Заполнение таблицы типы аудиторий
            db.ClassroomTypes.Add(new ClassroomType { СlassroomTypeName = "Лекционная аудитория" });
            db.ClassroomTypes.Add(new ClassroomType { СlassroomTypeName = "Аудиотрия для практических и лабораторных занятий" });
            db.SaveChanges();

            //Заполнение таблицы аудитории
            for (int i = 0; i < 20; i++)
            {
                db.Classrooms.Add( new Classroom { ClassroomNumber = i + 1, BuildingID = 1, NumberOfSeats = 100, ActivityTypeID = 1 });
            }
            db.SaveChanges();
            for (int i = 0; i < 80; i++)
            {
                db.Classrooms.Add(new Classroom { ClassroomNumber = i + 21, BuildingID = 1, NumberOfSeats = 30, ActivityTypeID = 2 });
            }
            db.SaveChanges();
            for (int i = 0; i < 15; i++)
            {
                db.Classrooms.Add(new Classroom { ClassroomNumber = i + 1, BuildingID = 2, NumberOfSeats = 100, ActivityTypeID = 1 });
            }
            db.SaveChanges();
            for (int i = 0; i < 40; i++)
            {
                db.Classrooms.Add(new Classroom {  ClassroomNumber = i + 16, BuildingID = 2, NumberOfSeats = 30, ActivityTypeID = 2 });
            }
            db.SaveChanges();

            //Заполнение таблицы дни неддели
            db.Days.Add(new Day {  DayName = "Понедельник", DayShortName = "ПН" });
            db.Days.Add(new Day {  DayName = "Вторник", DayShortName = "ВТ" });
            db.Days.Add(new Day {  DayName = "Среда", DayShortName = "СР" });
            db.Days.Add(new Day {  DayName = "Четверг", DayShortName = "ЧТ" });
            db.Days.Add(new Day {  DayName = "Пятница", DayShortName = "ПТ" });
            db.Days.Add(new Day {  DayName = "Суббота", DayShortName = "СБ" });
            db.SaveChanges();

            //Заполнение таблицы преподаватели 
            for (int i = 0; i < 1000; i++)
            {
                db.Teachers.Add( new Teacher { TeacherName = "TeacherName" + i + 1 });
            }
            db.SaveChanges();

            //Заполнение таблицы дисциплины
            for (int i = 0; i < 1000; i++)
            {
               db.Disciplines.Add(new Discipline { DisciplineNmae = "Discipline" + i + 1 });
            }
            db.SaveChanges();

            //Заполнение таблицы факультеты
            for (int i = 0; i < 10; i++)
            {
                db.Faculties.Add(new Faculty { FacultyName = "Faculty" + i + 1 });
            }
            db.SaveChanges();

            //Заолнение таблиц группы
            for (int i = 0; i < 50; i++)
            {
                db.Groups.Add(new Group { GroupName = "GroupName", GroupNumber = i + 1, FacultyID = randObj.Next(1, 10), NumberOfStudents = randObj.Next(15, 30) });
            }
            db.SaveChanges();
        }
    }
}
