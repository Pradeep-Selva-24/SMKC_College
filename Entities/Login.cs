using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class Login : BaseEntity
{
    [Column("S_UserId")]
    [Required]
    public string? UserId { get; set; }

    [Column("S_Password")]
    [Required]
    public string? Password { get; set; }

    [Column("D_LastLogin")]
    [Required]
    public DateTime LastLogin { get; set; }
}
