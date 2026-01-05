using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class PageMedia : BaseEntity
{
    [Column("S_Category")]
    [Required]
    public string? Category { get; set; }

    [Column("S_ImagePath")]
    [Required]
    public string? ImagePath { get; set; }

    [Column("S_Heading")]
    public string? Heading { get; set; }

    [Column("S_ShortContent")]
    public string? ShortContent { get; set; }

    [Column("D_Date")]
    public DateTime? Date { get; set; }

    [Column("I_DisplayOrder")]
    [Required]
    public int DisplayOrder { get; set; }
}
