using Microsoft.AspNetCore.Authorization;

namespace EVChargeFinder.Controllers
{
    using Microsoft.AspNetCore.Mvc;


    [Authorize]
    public abstract class ControllerBase : Controller
    {
        protected string GetUserId()
        {
            return User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}