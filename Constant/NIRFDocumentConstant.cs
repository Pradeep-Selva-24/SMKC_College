using College.Entities;

namespace College.Constant;

public static class NIRFDocumentConstant
{
    public static readonly List<NIRFDocument> lstNIRFDocument =
    [
        new NIRFDocument
        {
            Name = "NIRF Data Submission",
            Year = 2022,
            Path = "/documents/nirf/NIRF_Data_Submission.pdf",
            Order = 1,
        },

        new NIRFDocument
        {
            Name = "NIRF Report Summary",
            Year = 2023,
            Path = "/documents/nirf/NIRF_Report_Summary.pdf",
            Order = 2,
        },

        new NIRFDocument
        {
            Name = "Participation Certificate",
            Year = 2024,
            Path = "/documents/nirf/Participation_Certificate.pdf",
            Order = 3,
        }
    ];
}
