using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class ClubsDetails : BaseEntity
{
    [Column("F_ClubsMasterId")]
    [Required]
    public int ClubsMasterId { get; set; }

    [Column("S_Category")]
    [Required]
    public string? Category { get; set; }

    [Column("S_ImagePath")]
    [Required]
    public string? ImagePath { get; set; }

    [Column("S_Heading")]
    [Required]
    public string? Heading { get; set; }

    [Column("S_ShortContent")]
    [Required]
    public string? ShortContent { get; set; }

    [Column("I_DisplayOrder")]
    [Required]
    public int DisplayOrder { get; set; }
}
