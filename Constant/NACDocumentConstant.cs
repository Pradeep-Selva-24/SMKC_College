using College.Entities;

namespace College.Constant;

public static class NACDocumentConstant
{
    public static readonly List<NACDocument> lstNACDocument =
    [
        new NACDocument
        {
            Name = "SSR (Self Study Report)",
            Path = "/documents/nac/SSR.pdf",
            Order = 1,
        },

        new NACDocument
        {
            Name = "DVV Clarifications",
            Path = "/documents/nac/DVV_Clarifications.pdf",
            Order = 2,
        },

        new NACDocument
        {
            Name = "Peer Team Report",
            Path = "/documents/nac/Peer_Team_Report.pdf",
            Order = 3,
        },

        new NACDocument
        {
            Name = "Accreditation Certificate",
            Path = "/documents/nac/Accreditation_Certificate.pdf",
            Order = 4,
        }
    ];
}
