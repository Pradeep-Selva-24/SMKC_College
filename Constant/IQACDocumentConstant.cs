using College.Entities;

namespace College.Constant;

public static class IQACDocumentConstant
{
    public static readonly List<IQACDocument> lstIQACDocument =
    [
        new IQACDocument
        {
            Name = "Students",
            Path = "/documents/iqac/Students.pdf",
            Order = 1,
        },

        new IQACDocument
        {
            Name = "Teachers",
            Path = "/documents/iqac/Teachers.pdf",
            Order = 2,
        },

        new IQACDocument
        {
            Name = "Employers",
            Path = "/documents/iqac/Employers.pdf",
            Order = 3,
        },

        new IQACDocument
        {
            Name = "Alumnae",
            Path = "/documents/iqac/Alumnae.pdf",
            Order = 4,
        }
    ];
}
