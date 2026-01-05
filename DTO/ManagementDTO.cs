using College.Entities;

namespace College.DTO;

public class ManagementDTO
{
    public Management Management = new();
    public List<ManagementContent> lstManagementContent = [];
}
