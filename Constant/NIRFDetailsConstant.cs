using College.Entities;

namespace College.Constant;

public static class NIRFDetailsConstant
{
    public static readonly List<NIRFDetails> lstNIRFDetails =
    [
        new NIRFDetails
        {
            Name = "Institution Name",
            description = "Sree Muthukumaraswamy College",
            Order = 1,
        },

        new NIRFDetails
        {
            Name = "Participating Year",
            description = "2024",
            Order = 2,
        },

        new NIRFDetails
        {
            Name = "Category",
            description = "College",
            Order = 3,
        },

        new NIRFDetails
        {
            Name = "Application Status",
            description = "Submitted to NIRF Portal",
            Order = 4,
        },

        new NIRFDetails
        {
            Name = "Coordinator Name",
            description = "Dr. R. Priya – NIRF Coordinator",
            Order = 5,
        },

        new NIRFDetails
        {
            Name = "Email ID",
            description = "nirf@sreemuthukumaraswamycollege.edu.in",
            Order = 6,
        }
    ];
}
