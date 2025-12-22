
using System;
namespace College.Entities
{
    public class DepartmentsMembers : BaseEntity
    {
        public int F_DepartmentsMasterId { get; set; }
        public int I_Name { get; set; }
        public string S_Designation { get; set; }
        public string S_ImagePath { get; set; }
        public string S_Order { get; set; }
    }
}
