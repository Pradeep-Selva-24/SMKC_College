
using System;
namespace College.Entities
{
    public class DepartmentsMaster : BaseEntity
    {
        public int I_Department { get; set; }
        public string S_Category { get; set; }
        public string S_ImagePath { get; set; }
        public string S_Description { get; set; }
        public string S_Order { get; set; }
    }
}
