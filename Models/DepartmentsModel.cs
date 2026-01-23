using College.Entities;

namespace College.Models;

public class DepartmentsModel
{
    public DepartmentsMaster? DepartmentsMaster { get; set; } = new();
    public List<DepartmentsMembers> LstDepartmentsMembers { get; set; } = [];
    public List<DepartmentsDetails> LstDepartmentsDetails { get; set; } = [];
}
