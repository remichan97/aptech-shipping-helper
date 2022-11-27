﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Services.Offer;
using ShippingHelper.ViewModels;

namespace ShippingHelper.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = Roles.Shipper + "," + Roles.User)]
    public class OffersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IOfferServices _services;
        private readonly UserManager<Users> _userManager;

        public OffersController(AppDbContext context, IOfferServices services, UserManager<Users> userManager)
        {
            _context = context;
            this._services = services;
            this._userManager = userManager;
        }

        // GET: User/Offers
        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var cityId = user.CityId;

            var data = _services.GetOffersByCity(cityId);

            return View(data);
        }

        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> UserPosted()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var userId = user.Id;

            var data = _services.GetOffersCreatedByUser(userId);
            return View(data);
        }

        // GET: User/Offers/Details/5
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

        // GET: User/Offers/Create
        [Authorize(Roles = Roles.User)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Create([Bind("StartAddress,EndAddress,Note,Price")] ShippingOfferForm form)
        {
            if (ModelState.IsValid)
            {
                _services.Add(form);
                return RedirectToAction(nameof(Index));
            }
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
            if (offers == null)
            {
                return NotFound();
            }
            ViewBag["id"] = offers.Id;
            return View(offers);
        }

        [Authorize(Roles = Roles.Shipper)]
        public async Task<IActionResult> AcceptOffer(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);

            _services.AcceptOffer(id.Value, user.Id);
            return RedirectToAction(nameof(Index));

        }

        // POST: User/Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Edit(Guid id, [Bind("StartAddress,EndAddress,Note,Price")] ShippingOfferForm form)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _services.Update(form);
                }
                catch (InvalidOperationException)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag["id"] = id;
            return View(form);
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