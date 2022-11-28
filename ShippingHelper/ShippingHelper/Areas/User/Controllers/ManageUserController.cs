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

        public ManageUserController(UserManager<Users> userManager)
        {
            this._userManager = userManager;
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
        public async Task<ActionResult> EditProfileAsync(string userID, [Bind("FirstName,LastName,Email,CityId,Address,PhoneNumber")] UpdateUserForm form)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            user.FirstName = form.FirstName;
            user.LastName = form.LastName;
            user.Email = form.Email;
            user.CityId = form.CityId;
            user.Address = form.Address;
            user.PhoneNumber = form.PhoneNumber;

            var res = await _userManager.UpdateAsync(user);

            switch (res.Succeeded)
            {
                case true:
                    return RedirectToAction(nameof(Index), new { area = "User" });

                default:
                    TempData["Error"] = "something went wrong! Please try again!";
                    return View(form);
            }
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public async Task<IActionResult> ChangePassword(ChangePasswordForm form)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var res = await _userManager.ChangePasswordAsync(user, form.OldPassword, form.NewPassword);

            switch (res.Succeeded)
            {
                case true:
                    return RedirectToAction(nameof(Index), new { area = "User" });

                default:
                    TempData["Error"] = "Incorrect Password! Please try again";
                    return View(form);
            }
        }
    }
}