using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Height { get; set; }
    public decimal Weight { get; set; }

}
