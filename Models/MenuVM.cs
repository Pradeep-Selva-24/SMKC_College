namespace College.Models;

public class MenuVM
{
    public int Id { get; set; }
    public int? ParentMenuId { get; set; }
    public string MenuName { get; set; } = "";
    public string MenuUrl { get; set; } = "";
    public string Display { get; set; } = "N"; // ✅ "Y"/"N"
    public int Order { get; set; }

    public List<MenuVM> Children { get; set; } = new();
}
