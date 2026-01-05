using College.Entities;

namespace College.Constant;

public static class IQACMembersConstant
{
    public static readonly List<IQACMembers> lstIQACMembers =
    [
        new IQACMembers
        {
            Name = "Dr. G. Raja Priya",
            Designation = "Principal",
            Role = "Chairperson",
            Order = 1,
        },

        new IQACMembers
        {
            Name = "Mr. K. Vignesh",
            Designation = "Assistant Professor, Department of Commerce",
            Role = "IQAC Coordinator",
            Order = 2,
        },

        new IQACMembers
        {
            Name = "Mr. P. Aravind",
            Designation = "Assistant Professor",
            Role = "Faculty Representative",
            Order = 3,
        },

        new IQACMembers
        {
            Name = "Mrs. N. Priya",
            Designation = "Administrative Officer",
            Role = "Administrative Staff Representative",
            Order = 4,
        }
    ];
}
