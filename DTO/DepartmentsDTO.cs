using College.Entities;

namespace College.DTO;

public class DepartmentsDTO
{
    public DepartmentsMaster DepartmentsMaster = new();
    public List<DepartmentsMembers> lstDepartmentsMembers = [];
    public List<DepartmentsDetails> lstDepartmentsDetails = [];
}
