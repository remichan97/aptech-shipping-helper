using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentEmail.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Common.Constants;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Administrator)]
    public class ContactsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IFluentEmail _email;

        public ContactsController(AppDbContext context, IFluentEmail email)
        {
            _context = context;
            this._email = email;
        }

        // GET: Admin/Contacts
        public async Task<IActionResult> Index()
        {
              return View(await _context.Contacts.ToListAsync());
        }

        public async Task<IActionResult> ReplyMessage(Guid? id)
        {
            if (id is null) return NotFound();

            var data = await _context.Contacts.FindAsync(id.Value);

            if (data is null) return NotFound();

            ViewBag.Email = data.Email;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMail(IFormCollection formData)
        {
            string to = formData["Email"];
            string subject = formData["Subjects"];
            string message = formData["Message"];

            var sent = await _email.To(to).Subject(subject).Body(message).SendAsync();
            
            if (sent.Successful)
            {
                TempData["email"] = "Your resonse has been sent!";
            }
            else
            {
                TempData["email"] = "Something went wrong. Please try again!";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
