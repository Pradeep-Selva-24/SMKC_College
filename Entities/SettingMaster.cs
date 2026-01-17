using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Entities;

public class SettingMaster : BaseEntity
{
    [Column("S_Key")]
    [Required]
    public string? Key { get; set; }

    [Column("S_Value")]
    [Required]
    public string? Value { get; set; }
}
