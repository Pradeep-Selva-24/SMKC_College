using College.Entities;

namespace College.Constant;

public static class NIRFDetailsConstant
{
    public static readonly List<NIRFDetails> lstNIRFDetails =
    [
        new NIRFDetails
        {
            Name = "Institution Name",
            Description = "Sree Muthukumaraswamy College",
            Order = 1,
        },

        new NIRFDetails
        {
            Name = "Participating Year",
            Description = "2024",
            Order = 2,
        },

        new NIRFDetails
        {
            Name = "Category",
            Description = "College",
            Order = 3,
        },

        new NIRFDetails
        {
            Name = "Application Status",
            Description = "Submitted to NIRF Portal",
            Order = 4,
        },

        new NIRFDetails
        {
            Name = "Coordinator Name",
            Description = "Dr. R. Priya – NIRF Coordinator",
            Order = 5,
        },

        new NIRFDetails
        {
            Name = "Email ID",
            Description = "nirf@sreemuthukumaraswamycollege.edu.in",
            Order = 6,
        }
    ];
}
