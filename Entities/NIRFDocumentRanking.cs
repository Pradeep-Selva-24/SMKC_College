
using System;
namespace College.Entities
{
    public class NIRFDocumentRanking : BaseEntity
    {
        public int I_Year { get; set; }
        public string S_Category { get; set; }
        public string S_ParticipationStatus { get; set; }
        public string S_Score { get; set; }
    }
}
