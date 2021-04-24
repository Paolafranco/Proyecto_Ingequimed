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
    public class PreeclampsiasController : Controller
    {
        private readonly MainContext _context;

        public PreeclampsiasController(MainContext context)
        {
            _context = context;
        }

        // GET: Preeclampsias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Preeclampsia.ToListAsync());
        }

        // GET: Preeclampsias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preeclampsia = await _context.Preeclampsia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preeclampsia == null)
            {
                return NotFound();
            }

            return View(preeclampsia);
        }

        // GET: Preeclampsias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Preeclampsias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Preeclampsia preeclampsia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preeclampsia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preeclampsia);
        }

        // GET: Preeclampsias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preeclampsia = await _context.Preeclampsia.FindAsync(id);
            if (preeclampsia == null)
            {
                return NotFound();
            }
            return View(preeclampsia);
        }

        // POST: Preeclampsias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Preeclampsia preeclampsia)
        {
            if (id != preeclampsia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preeclampsia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreeclampsiaExists(preeclampsia.Id))
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
            return View(preeclampsia);
        }

        // GET: Preeclampsias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preeclampsia = await _context.Preeclampsia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preeclampsia == null)
            {
                return NotFound();
            }

            return View(preeclampsia);
        }

        // POST: Preeclampsias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preeclampsia = await _context.Preeclampsia.FindAsync(id);
            _context.Preeclampsia.Remove(preeclampsia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreeclampsiaExists(int id)
        {
            return _context.Preeclampsia.Any(e => e.Id == id);
        }
    }
}
