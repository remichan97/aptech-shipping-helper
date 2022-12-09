using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Services.Reports;

namespace ShippingHelper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportedMerchantsController : Controller
    {
        private readonly IReportMechantServices _services;

        public ReportedMerchantsController(IReportMechantServices services)
        {
            this._services = services;
        }

        // GET: Admin/ReportedMerchants
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportedMerchant = await _services.
            if (reportedMerchant == null)
            {
                return NotFound();
            }

            return View(reportedMerchant);
        }

    }
}
