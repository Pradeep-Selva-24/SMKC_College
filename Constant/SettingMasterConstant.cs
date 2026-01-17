using College.Entities;

namespace College.Constant;

public class SettingMasterConstant
{
    public static readonly List<SettingMaster> lstSettingMaster =
    [
        new SettingMaster
        {
            Key = "Start your application",
            Value = "~/",
        },
        new SettingMaster
        {
            Key = "Academic Calendar",
            Value = "~/",
        },
        new SettingMaster
        {
            Key = "Examinations",
            Value = "~/",
        },
        new SettingMaster
        {
            Key = "Results",
            Value = "~/",
        },
    ];
}
