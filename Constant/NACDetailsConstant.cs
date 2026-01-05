using College.Entities;

namespace College.Constant;

public static class NACDetailsConstant
{
    public static readonly List<NACDetails> lstNACDetails =
    [
        new NACDetails
        {
            Name = "Name of the Institution",
            description = "Sree Muthukumaraswamy College",
            Order = 1,
        },

        new NACDetails
        {
            Name = "Accrediting Agency",
            description = "National Assessment and Accreditation Council (NAC)",
            Order = 2,
        },

        new NACDetails
        {
            Name = "Affiliated To",
            description = "University of Madras",
            Order = 3,
        },

        new NACDetails
        {
            Name = "Accreditation Status",
            description = "Accredited (Cycle 1)",
            Order = 4,
        },

        new NACDetails
        {
            Name = "Grade Awarded",
            description = "B+",
            Order = 5,
        },

        new NACDetails
        {
            Name = "Year of Accreditation",
            description = "2023",
            Order = 6,
        },

        new NACDetails
        {
            Name = "Validity Period",
            description = "2023 – 2028",
            Order = 7,
        }
    ];
}
