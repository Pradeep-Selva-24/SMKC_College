using College.Entities;

namespace College.Constant;

public static class NACDetailsConstant
{
    public static readonly List<NACDetails> lstNACDetails =
    [
        new NACDetails
        {
            Name = "Name of the Institution",
            Description = "Sree Muthukumaraswamy College",
            Order = 1,
        },

        new NACDetails
        {
            Name = "Accrediting Agency",
            Description = "National Assessment and Accreditation Council (NAC)",
            Order = 2,
        },

        new NACDetails
        {
            Name = "Affiliated To",
            Description = "University of Madras",
            Order = 3,
        },

        new NACDetails
        {
            Name = "Accreditation Status",
            Description = "Accredited (Cycle 1)",
            Order = 4,
        },

        new NACDetails
        {
            Name = "Grade Awarded",
            Description = "B+",
            Order = 5,
        },

        new NACDetails
        {
            Name = "Year of Accreditation",
            Description = "2023",
            Order = 6,
        },

        new NACDetails
        {
            Name = "Validity Period",
            Description = "2023 – 2028",
            Order = 7,
        }
    ];
}
