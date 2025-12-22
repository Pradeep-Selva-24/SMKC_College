
using System.ComponentModel.DataAnnotations;

namespace College.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int I_Id { get; set; }

        public string? S_CreatedBy { get; set; }
        public DateTime? D_CreatedDate { get; set; }
        public string? S_ModifiedBy { get; set; }
        public DateTime? D_ModifiedDate { get; set; }
        public bool B_Status { get; set; }
    }
}
