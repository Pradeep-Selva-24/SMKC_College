using College.Entities;

namespace College.Constant;

public class SettingMasterConstant
{
    public static readonly List<SettingMaster> lstSettingMaster =
    [
        new SettingMaster
        {
            Key = "Application",
            Value = "/",
        },
        new SettingMaster
        {
            Key = "Academic Calendar",
            Value = "/",
        },
        new SettingMaster
        {
            Key = "Examinations",
            Value = "/",
        },
        new SettingMaster
        {
            Key = "Results",
            Value = "/",
        },
        new SettingMaster
        {
            Key = "Running Text",
            Value = "The institution offers a wide range of Undergraduate (UG), Postgraduate (PG) and Ph.D. programmes, comprising about 15 courses across diverse streams such as Business Administration, Commerce, Computer Science, Computer Applications and Criminology & Criminal Justice Science.",
        },
        new SettingMaster
        {
            Key = "Courses Eligibility",
            Value = "/",
        },
        new SettingMaster
        {
            Key = "Fee Structure",
            Value = "/",
        },

        #region Placement

        new SettingMaster
        {
            Key = "Overall Placement Rate",
            Value = "85%",
        },
        new SettingMaster
        {
            Key = "Companies Visited",
            Value = "40+",
        },
        new SettingMaster
        {
            Key = "Students Placed",
            Value = "150+",
        },
        new SettingMaster
        {
            Key = "MoUs Signed",
            Value = "20+",
        },

        #endregion
    ];
}
