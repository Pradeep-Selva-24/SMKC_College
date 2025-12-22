
using System;
namespace College.Entities
{
    public class DepartmentsDetails : BaseEntity
    {
        public int F_DepartmentsMasterId { get; set; }
        public string S_Category { get; set; }
        public string S_ImagePath { get; set; }
        public string S_Heading { get; set; }
        public string S_ShortContent { get; set; }
        public int I_DisplayOrder { get; set; }
    }
}
