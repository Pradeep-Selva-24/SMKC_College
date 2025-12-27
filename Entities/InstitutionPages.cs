using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class InstitutionPages : BaseEntity
{
    [Column("S_PageType")]
    [Required]
    public string? PageType { get; set; }

    [Column("S_Heading")]
    [Required]
    public string? Heading { get; set; }

    [Column("S_Content")]
    [Required]
    public string? Content { get; set; }
}
