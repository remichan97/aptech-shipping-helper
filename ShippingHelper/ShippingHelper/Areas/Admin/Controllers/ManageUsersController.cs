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
    public class ManageUsersController : Controller
    {
        private readonly UserManager<Users> _userManager;

        public ManageUsersController(UserManager<Users> userManager)
        {
            this._userManager = userManager;
        }

        // GET: ManageUsersController
        public ActionResult Index()
        {
            var data = _userManager.Users.ToList();
            return View(data);
        }

        // GET: ManageUsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageUsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
