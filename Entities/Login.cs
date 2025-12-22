
using System;
namespace College.Entities
{
    public class Login : BaseEntity
    {
        public string S_UserId { get; set; }
        public string S_Password { get; set; }
        public DateTime? D_LastLogin { get; set; }
    }
}
