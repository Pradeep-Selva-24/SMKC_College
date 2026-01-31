using College.Entities;

namespace College.Models;

public class PlacementModel
{
    public string? OverallPlacementRate { get; set; } = "0";
    public string? CompaniesVisited { get; set; } = "0";
    public string? StudentsPlaced { get; set; } = "0";
    public string? MoUsSigned { get; set; } = "0";
    public List<PageMedia> LstCompany { get; set; } = [];
    public List<PageMedia> LstBanner { get; set; } = [];
    public List<PlacementContact> LstPlacementContact { get; set; } = [];
}
