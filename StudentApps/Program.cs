using System;
using System.Data.Entity;

namespace StudentApps
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDBContext db = new AppDBContext();
            db.Students.Add(new Student() { Name = "Victor" });
            db.SaveChanges();
            Console.WriteLine("Data Saved");
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}

