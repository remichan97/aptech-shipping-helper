using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Models;
using ShippingHelper.ViewModels;

namespace ShippingHelper.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = Roles.Shipper + "," + Roles.User)]
    public class ManageUserController : Controller
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;

        public ManageUserController(UserManager<Users> userManager, SignInManager<Users> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        // GET: ManageUserController/Edit/5
        public async Task<IActionResult> EditProfile()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }

        // POST: ManageUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditProfileAsync(string userID, [Bind("FirstName,LastName,Email,Address,PhoneNumber")] UpdateUserForm form)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            user.FirstName = form.FirstName;
            user.LastName = form.LastName;
            user.Email = form.Email;
            user.Address = form.Address;
            user.PhoneNumber = form.PhoneNumber;

            var res = await _userManager.UpdateAsync(user);

            switch (res.Succeeded)
            {
                case true:
                    TempData["profile"] = "Successfully updated your profile!";
                    return RedirectToAction("Index", "RedirectUser");

                default:
                    TempData["Error"] = "something went wrong! Please try again!";
                    return View(form);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(IFormCollection formData)
        {
            string currentPassword = formData["current"];

            string newPassword = formData["new"];

            var user = await _userManager.GetUserAsync(HttpContext.User);

            var res = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);

            switch (res.Succeeded)
            {
                case true:
                    await _signInManager.SignOutAsync();
                    return RedirectToAction(nameof(Index), "Home", new { area = "default" });
                case false:
                    TempData["error"] = "Wrong Password, Please try again!";
                    return RedirectToAction(nameof(Index), "RedirectUser", new { area = "default" });
            }
        }
    }
}