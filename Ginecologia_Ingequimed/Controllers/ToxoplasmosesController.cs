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
    public class ToxoplasmosesController : Controller
    {
        private readonly MainContext _context;

        public ToxoplasmosesController(MainContext context)
        {
            _context = context;
        }

        // GET: Toxoplasmoses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Toxoplasmosis.ToListAsync());
        }

        // GET: Toxoplasmoses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toxoplasmosis = await _context.Toxoplasmosis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toxoplasmosis == null)
            {
                return NotFound();
            }

            return View(toxoplasmosis);
        }

        // GET: Toxoplasmoses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Toxoplasmoses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Toxoplasmosis toxoplasmosis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toxoplasmosis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(toxoplasmosis);
        }

        // GET: Toxoplasmoses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toxoplasmosis = await _context.Toxoplasmosis.FindAsync(id);
            if (toxoplasmosis == null)
            {
                return NotFound();
            }
            return View(toxoplasmosis);
        }

        // POST: Toxoplasmoses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Toxoplasmosis toxoplasmosis)
        {
            if (id != toxoplasmosis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toxoplasmosis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToxoplasmosisExists(toxoplasmosis.Id))
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
            return View(toxoplasmosis);
        }

        // GET: Toxoplasmoses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toxoplasmosis = await _context.Toxoplasmosis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toxoplasmosis == null)
            {
                return NotFound();
            }

            return View(toxoplasmosis);
        }

        // POST: Toxoplasmoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toxoplasmosis = await _context.Toxoplasmosis.FindAsync(id);
            _context.Toxoplasmosis.Remove(toxoplasmosis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToxoplasmosisExists(int id)
        {
            return _context.Toxoplasmosis.Any(e => e.Id == id);
        }
    }
}
