using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Services.Offer;

namespace ShippingHelper.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Administrator)]
    public class OffersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IOfferServices _services;

        public OffersController(AppDbContext context, IOfferServices services)
        {
            _context = context;
            this._services = services;
        }

        // GET: Admin/Offers
        public async Task<IActionResult> Index()
        {
            var data =await  _services.GetAllOffers();
            return View(data);
        }

        public async Task<IActionResult> CompletedOffer()
        {
            var data = await _services.GetOffersByStatus(OfferStatus.Finished);
            return View(data);
        }

        // GET: Admin/Offers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offers = await _services.GetOffers(id.Value);
            if (offers == null)
            {
                return NotFound();
            }

            return View(offers);
        }

        // POST: Admin/Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _services.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}