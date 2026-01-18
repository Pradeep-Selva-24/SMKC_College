using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class AQARReport : BaseEntity
{
    [Column("S_AcademicYear")]
    [Required]
    public string? AcademicYear { get; set; }

    [Column("S_ReportTitle")]
    [Required]
    public string? ReportTitle { get; set; }

    [Column("S_FilePath")]
    [Required]
    public string? FilePath { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
