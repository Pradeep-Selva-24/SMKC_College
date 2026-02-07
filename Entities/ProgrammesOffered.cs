using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class ProgrammesOffered : BaseEntity
{
    [Column("S_Course")]
    [Required]
    public string? Course { get; set; }

    [Column("S_Category")]
    [Required]
    public string? Category { get; set; }

    [Column("S_ImagePath")]
    [Required]
    public string? ImagePath { get; set; }

    [Column("S_StudentCount")]
    [Required]
    public int StudentCount { get; set; }

    [Column("S_SyllabusPath")]
    [Required]
    public string? SyllabusPath { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
