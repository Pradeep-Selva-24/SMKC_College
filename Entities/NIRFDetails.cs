using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class NIRFDetails : BaseEntity
{
    [Column("S_Name")]
    [Required]
    public string? Name { get; set; }

    [Column("S_Description")]
    [Required]
    public string? Description { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
