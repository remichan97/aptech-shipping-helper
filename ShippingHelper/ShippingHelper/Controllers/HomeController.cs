using Microsoft.AspNetCore.Mvc;
using ShippingHelper.Core.Models;
using ShippingHelper.Models;
using ShippingHelper.Services.ContactsUs;
using System.Diagnostics;

namespace ShippingHelper.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IContactServices _services;

        public HomeController(ILogger<HomeController> logger, IContactServices services)
		{
			_logger = logger;
            this._services = services;
        }

		public IActionResult Index()
		{
            if (User.Identity!.IsAuthenticated)
            {
				return RedirectToAction("Index", "RedirectUser", new {area = "default"});
            }

            return View();
		}

        public IActionResult ContactUs()
        {
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ContactUs([Bind("FullName, Email, Subjects, Message")] Contacts contacts)
		{
			if(ModelState.IsValid)
			{
				contacts.Id = Guid.NewGuid();
				await _services.SendMessage(contacts);
				TempData["Message"] = "Thank you! Your message has been sent! We'll reach out to you soon.";
				return RedirectToAction("ContactUs", "Home", new {area = "default"});
			}
			return View(contacts);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}