using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class NAACDetails : BaseEntity
{
    [Column("S_Name")]
    [Required]
    public string? Name { get; set; }

    [Column("S_description")]
    [Required]
    public string? description { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
