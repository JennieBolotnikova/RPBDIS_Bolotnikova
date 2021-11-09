using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using LAB4.Models;


namespace LAB4.Data
{
    public class TimetableContext : DbContext
    {
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Bell> Bells { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<ClassroomType> ClassroomTypes { get; set; }
        public TimetableContext(DbContextOptions<TimetableContext> options): base(options)
        {
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
            //Database.EnsureCreated();   // создаем бд с новой схемой
            //    Database.EnsureCreated();
        }
        

    }
}