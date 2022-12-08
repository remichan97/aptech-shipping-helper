using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Services.AcceptOffer;
using ShippingHelper.Services.Offer;
using ShippingHelper.ViewModels;

namespace ShippingHelper.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = Roles.Shipper + "," + Roles.User)]
    public class OffersController : Controller
    {
        private readonly IOfferServices _services;
        private readonly IAcceptOfferService _offerService;
        private readonly UserManager<Users> _userManager;

        public OffersController(IOfferServices services, IAcceptOfferService offerService, UserManager<Users> userManager)
        {
            this._services = services;
            this._offerService = offerService;
            this._userManager = userManager;
        }

        // GET: User/Offers
        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var cityId = user.CityId;

            var data = await _services.GetOffersByCity(cityId);

            return View(data);
        }

        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> UserPosted()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var userId = user.Id;

            var data = await _services.GetOffersCreatedByUser(userId);
            return View(data);
        }

        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> AcceptedOffers()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var userId = user.Id;

            var data = await _services.GetOffersByUserAndByStatus(userId, OfferStatus.Accepted);

            return View(data);

        }

        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> FinishedOffers()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var userId = user.Id;

            var data = await _services.GetOffersByUserAndByStatus(userId, OfferStatus.Finished);

            return View(data);

        }

        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> OngoingOffers()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var userId = user.Id;

            var data = await _services.GetCreatedOFferByUserAndStatus(userId, OfferStatus.Delivering);

            return View(data);

        }

        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> CompletedOffers()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var userId = user.Id;

            var data = await _services.GetCreatedOFferByUserAndStatus(userId, OfferStatus.Finished);

            return View(data);
        }

        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> ChangeOfferStatus(Guid? id, OfferStatus status)
        {
            if (id is null) return NotFound();

            await _services.ChangeOfferStatus(status, id.Value);

            return RedirectToAction("Details", new { id = id });
        }

        // GET: User/Offers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            string userId = await _offerService.GetUserIdForAcceptOffer(id.Value);

            if (id == null)
            {
                return NotFound();
            }

            var offers = await _services.GetOffers(id.Value);
            if (offers == null)
            {
                return NotFound();
            }

            if (offers.Status == OfferStatus.Open)
            {
                var user = await _userManager.FindByIdAsync(userId);

                ViewBag.userId = userId;
                ViewBag.FirstName = user.FirstName; ViewBag.LastName = user.LastName;
            }
            return View(offers);
        }

        // GET: User/Offers/Create
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> CreateAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var start = user.Address;

            ViewBag.Address = start;

            return View();
        }

        // POST: User/Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Create([Bind("StartAddress,EndAddress,Note,Price,ProductName,Quantity,Description,ImageFile")] ShippingOfferForm form)
        {

            var user = await _userManager.GetUserAsync(HttpContext.User);

            var id = user.Id;

            int cityId = user.CityId;

            if (ModelState.IsValid)
            {
                await _services.Add(form, id, cityId);
                return RedirectToAction(nameof(UserPosted));
            }

            var start = user.Address;

            ViewBag.Address = start;

            return View(form);
        }

        // GET: User/Offers/Edit/5
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offers = await _services.GetOffers(id.Value);
            if (offers == null || offers.Status != OfferStatus.Open)
            {
                return NotFound();
            }

            ShippingOfferForm data = new ShippingOfferForm
            {
                StartAddress = offers.StartAddress,
                EndAddress = offers.EndAddress,
                Price = offers.Price,
                Note = offers.Note
            };

            ViewBag["id"] = offers.Id;
            return View(data);
        }

        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> AcceptOffer(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);

            await _services.AcceptOffer(id.Value, user.Id);
            TempData["accept"] = "You have accepted this offer!";
            return RedirectToAction(nameof(Details));
        }

        // POST: User/Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Edit(Guid id, [Bind("EndAddress,Note,Price")] ShippingOfferForm form)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _services.Update(form, id);
                }
                catch (ArgumentNullException)
                {
                    return NotFound();
                }
                catch (InvalidOperationException)
                {
                    TempData["error"] = "Unable to proceed, the offer has been accepted";
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag["id"] = id;
            return View(form);
        }

        [Authorize(Roles = Roles.User)]
        [HttpPost]
        public async Task<IActionResult> ReportMerchant(IFormCollection form)
        {
            string userID = form["userId"];
            int reason = int.Parse(form["reason"]);
            string note = form["note"];

            ReportedMerchant report = new ReportedMerchant
            {
                UserId = userID,
                Description = note
            };

            switch (reason)
            {
                case 1:
                    report.ReportType = ReportedMerchant.ReportTypes.AcceptedButNotCompleteShipping;
                    break;
                case 2:
                    report.ReportType = ReportedMerchant.ReportTypes.MissingOrBrokenPackage;
                    break;
                case 3:
                    report.ReportType = ReportedMerchant.ReportTypes.BadPersonality;
                    break;
                case 4:
                    report.ReportType = ReportedMerchant.ReportTypes.Other;
                    break;
            }

            await _services.ReportMerchants(report);
            TempData["report"] = "Your report has been submitted! Thank you for letting us know";
            return RedirectToAction(nameof(Details));

        }

        // GET: User/Offers/Delete/5
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _services.GetOffers(id.Value);

            if (data == null)
            {
                return NotFound();
            }

            return View(data);
        }

        // POST: User/Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _services.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}