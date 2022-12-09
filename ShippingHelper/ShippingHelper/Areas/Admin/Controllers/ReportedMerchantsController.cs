using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportedMerchantsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportedMerchantsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ReportedMerchants
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ReportedMerchants.Include(r => r.Users);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/ReportedMerchants/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ReportedMerchants == null)
            {
                return NotFound();
            }

            var reportedMerchant = await _context.ReportedMerchants
                .Include(r => r.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportedMerchant == null)
            {
                return NotFound();
            }

            return View(reportedMerchant);
        }

        // GET: Admin/ReportedMerchants/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id");
            return View();
        }

        // POST: Admin/ReportedMerchants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ReportType,Description")] ReportedMerchant reportedMerchant)
        {
            if (ModelState.IsValid)
            {
                reportedMerchant.Id = Guid.NewGuid();
                _context.Add(reportedMerchant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id", reportedMerchant.UserId);
            return View(reportedMerchant);
        }

        // GET: Admin/ReportedMerchants/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ReportedMerchants == null)
            {
                return NotFound();
            }

            var reportedMerchant = await _context.ReportedMerchants.FindAsync(id);
            if (reportedMerchant == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id", reportedMerchant.UserId);
            return View(reportedMerchant);
        }

        // POST: Admin/ReportedMerchants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,ReportType,Description")] ReportedMerchant reportedMerchant)
        {
            if (id != reportedMerchant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportedMerchant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportedMerchantExists(reportedMerchant.Id))
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
            ViewData["UserId"] = new SelectList(_context.Set<Users>(), "Id", "Id", reportedMerchant.UserId);
            return View(reportedMerchant);
        }

        // GET: Admin/ReportedMerchants/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ReportedMerchants == null)
            {
                return NotFound();
            }

            var reportedMerchant = await _context.ReportedMerchants
                .Include(r => r.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportedMerchant == null)
            {
                return NotFound();
            }

            return View(reportedMerchant);
        }

        // POST: Admin/ReportedMerchants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ReportedMerchants == null)
            {
                return Problem("Entity set 'AppDbContext.ReportedMerchants'  is null.");
            }
            var reportedMerchant = await _context.ReportedMerchants.FindAsync(id);
            if (reportedMerchant != null)
            {
                _context.ReportedMerchants.Remove(reportedMerchant);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportedMerchantExists(Guid id)
        {
          return _context.ReportedMerchants.Any(e => e.Id == id);
        }
    }
}
