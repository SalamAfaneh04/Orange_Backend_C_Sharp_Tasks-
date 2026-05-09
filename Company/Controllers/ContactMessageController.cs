using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Company.Data;
using Company.Models;

namespace Company.Controllers
{
    public class ContactMessageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactMessageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ContactMessage
        public async Task<IActionResult> Index()
        {
            return View(await _context.Messages.ToListAsync());
        }

        // GET: ContactMessage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMessageModel = await _context.Messages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactMessageModel == null)
            {
                return NotFound();
            }

            return View(contactMessageModel);
        }

        // GET: ContactMessage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactMessage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SenderName,Email,Message,SentAt")] ContactMessageModel contactMessageModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactMessageModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactMessageModel);
        }

        // GET: ContactMessage/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMessageModel = await _context.Messages.FindAsync(id);
            if (contactMessageModel == null)
            {
                return NotFound();
            }
            return View(contactMessageModel);
        }

        // POST: ContactMessage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SenderName,Email,Message,SentAt")] ContactMessageModel contactMessageModel)
        {
            if (id != contactMessageModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactMessageModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactMessageModelExists(contactMessageModel.Id))
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
            return View(contactMessageModel);
        }

        // GET: ContactMessage/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMessageModel = await _context.Messages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactMessageModel == null)
            {
                return NotFound();
            }

            return View(contactMessageModel);
        }

        // POST: ContactMessage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactMessageModel = await _context.Messages.FindAsync(id);
            if (contactMessageModel != null)
            {
                _context.Messages.Remove(contactMessageModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactMessageModelExists(int id)
        {
            return _context.Messages.Any(e => e.Id == id);
        }
    }
}
