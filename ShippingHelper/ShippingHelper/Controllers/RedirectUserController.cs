using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Controllers
{
    public class RedirectUserController : Controller
    {
        private readonly UserManager<Users> _userManager;

        public RedirectUserController(UserManager<Users> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var roles = await _userManager.GetRolesAsync(user);
            
            if (roles.Contains(Roles.Administrator))
            {
                return RedirectToAction("Index", "Offers", new { area = "Admin"});
            }
            else
            {
                return RedirectToAction("Index", "Offers", new { area = "User" });
            }

        }
    }
}
