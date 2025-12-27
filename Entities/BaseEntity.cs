
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public abstract class BaseEntity
{
    [Key]
    [Column("I_Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("S_CreatedBy")]
    [Required]
    public string? CreatedBy { get; set; }

    [Column("D_CreatedDate")]
    [Required]
    public DateTime? CreatedDate { get; set; }

    [Column("S_ModifiedBy")]
    public string? ModifiedBy { get; set; }

    [Column("D_ModifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    [Column("B_Status")]
    [Required]
    public bool Status { get; set; }
}
