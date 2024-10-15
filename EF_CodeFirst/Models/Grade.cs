using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models;

public class Grade
{
    [Key]
    public int GradeId { get; set; }

    public string GradeName { get; set; }

    public string Section { get; set; }

    [ForeignKey("StudentID")]
    public int StudentID { get; set; }

   
  //  public Student Student { get; set; }
}
