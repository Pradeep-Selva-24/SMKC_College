
using System;
namespace College.Entities
{
    public class AQARReport : BaseEntity
    {
        public string S_AcademicYear { get; set; }
        public string S_ReportTitle { get; set; }
        public string S_FilePath { get; set; }
        public int I_Order { get; set; }
    }
}
