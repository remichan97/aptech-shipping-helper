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
            var appDbContext = _context.Offers.Include(o => o.Users);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Offers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Offers == null)
            {
                return NotFound();
            }

            var offers = await _context.Offers
                .Include(o => o.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offers == null)
            {
                return NotFound();
            }

            return View(offers);
        }

        // GET: Admin/Offers/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id");
            return View();
        }

        // POST: Admin/Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartAddress,EndAddress,Note,Price,PostedDate,Status,UserId")] Offers offers)
        {
            if (ModelState.IsValid)
            {
                offers.Id = Guid.NewGuid();
                _context.Add(offers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id", offers.UserId);
            return View(offers);
        }

        // GET: Admin/Offers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Offers == null)
            {
                return NotFound();
            }

            var offers = await _context.Offers.FindAsync(id);
            if (offers == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id", offers.UserId);
            return View(offers);
        }

        // POST: Admin/Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StartAddress,EndAddress,Note,Price,PostedDate,Status,UserId")] Offers offers)
        {
            if (id != offers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OffersExists(offers.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id", offers.UserId);
            return View(offers);
        }

        // GET: Admin/Offers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Offers == null)
            {
                return NotFound();
            }

            var offers = await _context.Offers
                .Include(o => o.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offers == null)
            {
                return NotFound();
            }

            return View(offers);
        }

        // POST: Admin/Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Offers == null)
            {
                return Problem("Entity set 'AppDbContext.Offers'  is null.");
            }
            var offers = await _context.Offers.FindAsync(id);
            if (offers != null)
            {
                _context.Offers.Remove(offers);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OffersExists(Guid id)
        {
            return _context.Offers.Any(e => e.Id == id);
        }
    }
}