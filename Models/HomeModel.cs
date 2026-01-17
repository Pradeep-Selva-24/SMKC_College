using College.DTO;
using College.Entities;

namespace College.Models;

public class HomeModel
{
    public string YearsOfExperience { get; set; } = "0";
    public string Students { get; set; } = "0";
    public string StaffMembers { get; set; } = "0";
    public List<ManagementDTO> LstManagementDTO { get; set; } = [];
    public List<PageMedia> LstCampusLife { get; set; } = [];
    public List<PageMedia> LstSports { get; set; } = [];
    public List<PageMedia> LstLatestNews { get; set; } = [];
}