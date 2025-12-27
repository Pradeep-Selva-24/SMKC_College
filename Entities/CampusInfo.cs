using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class CampusInfo : BaseEntity
{
    [Column("S_Category")]
    [Required]
    public string? Category { get; set; }

    [Column("I_Count")]
    [Required]
    public int Count { get; set; }
}
