using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ginecologia_Ingequimed.Data;
using Ginecologia_Ingequimed.Models;

namespace Ginecologia_Ingequimed.Controllers
{
    public class AmenorreasController : Controller
    {
        private readonly MainContext _context;

        public AmenorreasController(MainContext context)
        {
            _context = context;
        }

        // GET: Amenorreas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Amenorrea.ToListAsync());
        }

        // GET: Amenorreas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amenorrea = await _context.Amenorrea
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amenorrea == null)
            {
                return NotFound();
            }

            return View(amenorrea);
        }

        // GET: Amenorreas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Amenorreas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Amenorrea amenorrea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amenorrea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amenorrea);
        }

        // GET: Amenorreas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amenorrea = await _context.Amenorrea.FindAsync(id);
            if (amenorrea == null)
            {
                return NotFound();
            }
            return View(amenorrea);
        }

        // POST: Amenorreas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Amenorrea amenorrea)
        {
            if (id != amenorrea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amenorrea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmenorreaExists(amenorrea.Id))
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
            return View(amenorrea);
        }

        // GET: Amenorreas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amenorrea = await _context.Amenorrea
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amenorrea == null)
            {
                return NotFound();
            }

            return View(amenorrea);
        }

        // POST: Amenorreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amenorrea = await _context.Amenorrea.FindAsync(id);
            _context.Amenorrea.Remove(amenorrea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmenorreaExists(int id)
        {
            return _context.Amenorrea.Any(e => e.Id == id);
        }
    }
}
