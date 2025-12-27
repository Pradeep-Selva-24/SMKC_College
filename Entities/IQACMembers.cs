using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class IQACMembers : BaseEntity
{
    [Column("S_Name")]
    [Required]
    public string? Name { get; set; }

    [Column("S_Designation")]
    [Required]
    public string? Designation { get; set; }

    [Column("S_Role")]
    [Required]
    public string? Role { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
