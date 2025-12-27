using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class LatestNews : BaseEntity
{
    [Column("S_Heading")]
    [Required]
    public string? Heading { get; set; }

    [Column("S_ShortContent")]
    [Required]
    public string? ShortContent { get; set; }

    [Column("D_Date")]
    [Required]
    public DateTime Date { get; set; }

    [Column("S_ImagePath")]
    [Required]
    public string? ImagePath { get; set; }

    [Column("I_DisplayOrder")]
    [Required]
    public int DisplayOrder { get; set; }
}
