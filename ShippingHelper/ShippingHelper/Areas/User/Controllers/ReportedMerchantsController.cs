using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Areas.User.Controllers
{
    [Area("User")]
    public class ReportedMerchantsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportedMerchantsController(AppDbContext context)
        {
            _context = context;
        }

        // POST: User/ReportedMerchants/Create
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
    }
}
