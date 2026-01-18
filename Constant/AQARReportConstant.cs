using College.Entities;

namespace College.Constant;

public static class AQARReportConstant
{
    public static readonly List<AQARReport> lstAQARReport =
    [
        new AQARReport
        {
            AcademicYear = "2021-2022",
            ReportTitle = "AQAR Report 2021–2022",
            FilePath = "/documents/aqar/AQAR_2021_2022.pdf",
            Order = 1,
        },

        new AQARReport
        {
            AcademicYear = "2022-2023",
            ReportTitle = "AQAR Report 2022–2023",
            FilePath = "/documents/aqar/AQAR_2022_2023.pdf",
            Order = 2,
        },

        new AQARReport
        {
            AcademicYear = "2023-2024",
            ReportTitle = "AQAR Report 2023–2024",
            FilePath = "/documents/aqar/AQAR_2023_2024.pdf",
            Order = 3,
        }
    ];
}
