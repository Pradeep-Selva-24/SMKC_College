
using System;
namespace College.Entities
{
    public class ClubsDetails : BaseEntity
    {
        public int F_ClubsMasterId { get; set; }
        public string S_Category { get; set; }
        public string S_ImagePath { get; set; }
        public string S_Heading { get; set; }
        public string S_ShortContent { get; set; }
        public int I_DisplayOrder { get; set; }
    }
}
