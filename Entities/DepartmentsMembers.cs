using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class DepartmentsMembers : BaseEntity
{
    [Column("F_DepartmentsMasterId")]
    [Required]
    public int DepartmentsMasterId { get; set; }

    [Column("S_Name")]
    [Required]
    public string? Name { get; set; }

    [Column("S_Designation")]
    [Required]
    public string? Designation { get; set; }

    [Column("S_ImagePath")]
    [Required]
    public string? ImagePath { get; set; }

    [Column("I_Order")]
    [Required]
    public int I_Order { get; set; }
}
