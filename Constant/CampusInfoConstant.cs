using College.Entities;

namespace College.Constant;

public static class CampusInfoConstant
{
    public static readonly List<CampusInfo> lstCampusInfo =
    [
        new CampusInfo
        {
            Category = "Years Of Experience",
            Count = 25,
        },
        new CampusInfo
        {
            Category = "Students",
            Count = 20000,
        },
        new CampusInfo
        {
            Category = "Staff Members",
            Count = 99,
        },
    ];
}
