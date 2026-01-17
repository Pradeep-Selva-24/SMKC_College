using College.Entities;

namespace College.Constant;

public static class LoginConstant
{
    public static readonly List<Login> lstLogin =
    [
        new Login
        {
            UserId = "Admin",
            Password = "Admin@SMKC@2025",
            LastLogin = DateTime.Now,
            IsActive = true,
        },
    ];
}