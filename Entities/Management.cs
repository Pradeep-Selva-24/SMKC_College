using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class Management : BaseEntity
{
    [Column("S_Name")]
    [Required]
    public string? Name { get; set; }

    [Column("S_Designation")]
    [Required]
    public string? Designation { get; set; }

    [Column("I_DisplayOrder")]
    [Required]
    public int DisplayOrder { get; set; }
}
