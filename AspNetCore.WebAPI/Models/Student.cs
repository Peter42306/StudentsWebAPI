using Microsoft.EntityFrameworkCore;

namespace AspNetCore.WebAPI.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Frodo", Surname = "Baggins", Age = 33, GPA = 12.0 },
                new Student { Id = 2, Name = "Samwise", Surname = "Gamgee", Age = 35, GPA = 11.5 },
                new Student { Id = 3, Name = "Meriadoc", Surname = "Brandybuck", Age = 30, GPA = 10.8 },
                new Student { Id = 4, Name = "Peregrin", Surname = "Took", Age = 29, GPA = 10.2 },
                new Student { Id = 5, Name = "Aragorn", Surname = "Elessar", Age = 45, GPA = 13.0 },
                new Student { Id = 6, Name = "Gimli", Surname = "Son of Glóin", Age = 140, GPA = 11.7 },
                new Student { Id = 7, Name = "Legolas", Surname = "Greenleaf", Age = 2931, GPA = 13.5 },
                new Student { Id = 8, Name = "Boromir", Surname = "of Gondor", Age = 41, GPA = 9.9 },
                new Student { Id = 9, Name = "Gandalf", Surname = "the Grey", Age = 2019, GPA = 14.0 },
                new Student { Id = 10, Name = "Gollum", Surname = "Smeagol", Age = 589, GPA = 6.6 }
            );
        }

    }

    public class Student
    {        
        public int Id { get; set; }        
        public string? Name { get; set; }        
        public string? Surname { get; set; }        
        public int Age { get; set; }        
        public double GPA { get; set; }
    }
}
