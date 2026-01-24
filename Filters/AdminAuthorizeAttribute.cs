using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace College.Filters;
public class AdminAuthorizeAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var session = context.HttpContext.Session;
        var adminUser = session.GetString("AdminUser");


        if (string.IsNullOrEmpty(adminUser))
        {
            context.Result = new RedirectToActionResult("Login", "Login", null);
            //context.Result = new RedirectToActionResult("AccessDenied", "Home", null);
        }
        base.OnActionExecuting(context);
    }
}
