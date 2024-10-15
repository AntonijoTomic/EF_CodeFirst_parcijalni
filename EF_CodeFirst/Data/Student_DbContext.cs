using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data;




public class Student_DbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=StudentsDB;Trusted_Connection=true;TrustServerCertificate=true");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //TODO: FluentApi

        modelBuilder.Entity<Student>()
            .HasIndex(x => new { x.StudentName, x.StudentID })
            .IsUnique();


        modelBuilder.Entity<Grade>()
            .HasIndex(x => x.GradeId)
            .IsUnique();





        //TODO: EF Core Configurations

        modelBuilder.Entity<Student>()
            .HasData(
         new Student() { StudentID = 1, StudentName = "Antonijo Tomic", DateOfBirth = (DateTime.Now).AddYears(-22), Height = 185, Weight = 90 },
         new Student() { StudentID = 2, StudentName = "Ratko Cosic", DateOfBirth = (DateTime.Now).AddYears(-35), Height = 190, Weight = 90 }
            );


                modelBuilder.Entity<Grade>().HasData(
                new Grade { GradeId = 1, GradeName = "Math", Section = "ASP", StudentID = 1 },
                new Grade { GradeId = 2, GradeName = "Biology", Section = "ASP", StudentID = 1 },
                new Grade { GradeId = 3, GradeName = "Geography ", Section = "ASP", StudentID = 1 },
                new Grade { GradeId = 4, GradeName = "Computer Science", Section = "ASP", StudentID = 2 },
                new Grade { GradeId = 5, GradeName = "Physics", Section = "ASP", StudentID = 2 },
                new Grade { GradeId = 6, GradeName = "English", Section = "ASP", StudentID = 2 },
                new Grade { GradeId = 7, GradeName = "History", Section = "ASP", StudentID = 2 }
            );

        //    public int StudentID { get; set; }
        //public string StudentName { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public decimal Height { get; set; }
        //public decimal Weight { get; set; }

        //modelBuilder.Entity<Pet>().HasData();

        base.OnModelCreating(modelBuilder);
    }
}