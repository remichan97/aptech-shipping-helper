using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Administrator)]
    public class UsersController : Controller
    {
        private readonly UserManager<Users> _userManager;
        private readonly PasswordHasher<Users> _passwordHasher = new PasswordHasher<Users>();

        public UsersController(UserManager<Users> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IActionResult> LockUserAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user is null) return NotFound();

            await _userManager.SetLockoutEnabledAsync(user, true);

            await _userManager.SetLockoutEndDateAsync(user, DateTime.Now.AddDays(7));

            TempData["message"] = "User has been banned from the system!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ResetUserPassword(string email)
        {
            var user = await _userManager.FindByIdAsync(email);

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            await _userManager.ResetPasswordAsync(user, token, "ShipLink@123");

            TempData["message"] = "Password Reset completed!";
            return RedirectToAction(nameof(Index));
        }
    }
}
