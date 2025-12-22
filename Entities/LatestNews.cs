
using System;
namespace College.Entities
{
    public class LatestNews : BaseEntity
    {
        public string S_ImagePath { get; set; }
        public string S_Heading { get; set; }
        public string S_ShortContent { get; set; }
        public DateTime D_Date { get; set; }
        public int I_DisplayOrder { get; set; }
    }
}
