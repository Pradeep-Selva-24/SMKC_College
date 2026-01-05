using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class NIRFDocument : BaseEntity
{
    [Column("S_Name")]
    [Required]
    public string? Name { get; set; }

    [Column("I_Year")]
    [Required]
    public int? Year { get; set; }

    [Column("S_Path")]
    [Required]
    public string? Path { get; set; }

    [Column("I_Order")]
    [Required]
    public int Order { get; set; }
}
