using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace College.Entities;
public class NIRFDocumentRanking : BaseEntity
{
    [Column("I_Year")]
    [Required]
    public int Year { get; set; }

    [Column("S_Category")]
    [Required]
    public string? Category { get; set; }

    [Column("S_ParticipationStatus")]
    [Required]
    public string? ParticipationStatus { get; set; }

    [Column("S_Score")]
    [Required]
    public string? Score { get; set; }
}
