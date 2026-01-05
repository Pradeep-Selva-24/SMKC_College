using College.Entities;

namespace College.Constant;

public static class NIRFDocumentRankingConstant
{
    public static readonly List<NIRFDocumentRanking> lstNIRFDocumentRanking =
    [
        new NIRFDocumentRanking
        {
            Year = 2024,
            Category = "College",
            ParticipationStatus = "Participated",
            Score = "Under Evaluation",
        },

        new NIRFDocumentRanking
        {
            Year = 2023,
            Category = "College",
            ParticipationStatus = "Submitted",
            Score = "Awaiting Results",
        },

        new NIRFDocumentRanking
        {
            Year = 2022,
            Category = "College",
            ParticipationStatus = "Participated",
            Score = "Not Ranked",
        }
    ];
}
