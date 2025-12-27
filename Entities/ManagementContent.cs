using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class ManagementContent : BaseEntity
{
    [Column("F_ManagementId")]
    [Required]
    public int ManagementId { get; set; }

    [Column("S_Content")]
    [Required]
    public string? Content { get; set; }
}
