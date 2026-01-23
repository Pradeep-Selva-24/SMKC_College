using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class ClubsMaster : BaseEntity
{
    [Column("S_Clubs")]
    [Required]
    public string? Clubs { get; set; }

    [Column("S_FullName")]
    [Required]
    public string? FullName { get; set; }

    [Column("S_Description")]
    [Required]
    public string? Description { get; set; }

    [Column("I_DisplayOrder")]
    [Required]
    public int DisplayOrder { get; set; }
}
