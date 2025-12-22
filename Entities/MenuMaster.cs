
using System;
namespace College.Entities
{
    public class MenuMaster : BaseEntity
    {
        public int? F_ParentMenuId { get; set; }
        public string S_MenuName { get; set; }
        public string S_MenuUrl { get; set; }
        public string B_Display { get; set; }
        public int I_Order { get; set; }
    }
}
