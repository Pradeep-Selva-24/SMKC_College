using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class MenuMaster : BaseEntity
{
    [Column("F_ParentMenuId")]
    public int? ParentMenuId { get; set; }

    [Column("S_MenuName")]
    [Required]
    public string? MenuName { get; set; }

    [Column("S_MenuUrl")]
    [Required]
    public string? MenuUrl { get; set; }

    [Column("B_Display")]
    [Required]
    public string? Display { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
