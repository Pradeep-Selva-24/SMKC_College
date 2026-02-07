using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class DepartmentsMaster : BaseEntity
{
    [Column("S_Department")]
    [Required]
    public string? Department { get; set; }

    [Column("S_ImagePath")]
    [Required]
    public string? ImagePath { get; set; }

    [Column("S_Description")]
    [Required]
    public string? Description { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
