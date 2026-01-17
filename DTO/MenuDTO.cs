using College.Entities;

namespace College.DTO;

public class MenuDTO
{
    public MenuMaster Menu = new();
    public List<MenuDTO> Children = [];
}
