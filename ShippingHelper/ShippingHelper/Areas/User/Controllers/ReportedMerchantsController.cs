using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Services.Reports;

namespace ShippingHelper.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class ReportedMerchantsController : Controller
    {
        private readonly IReportMechantServices _services;

        public ReportedMerchantsController(IReportMechantServices services)
        {
            this._services = services;
        }

        // POST: User/ReportedMerchants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,ReportType,Description")] ReportedMerchant reportedMerchant)
        {
            if (ModelState.IsValid)
            {
                await _services.Add(reportedMerchant);
                return RedirectToAction(nameof(Index));
            }
            return View(reportedMerchant);
        }
    }
}
