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
    public class MenopausiasController : Controller
    {
        private readonly MainContext _context;

        public MenopausiasController(MainContext context)
        {
            _context = context;
        }

        // GET: Menopausias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Menopausia.ToListAsync());
        }

        // GET: Menopausias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menopausia = await _context.Menopausia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menopausia == null)
            {
                return NotFound();
            }

            return View(menopausia);
        }

        // GET: Menopausias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Menopausias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Menopausia menopausia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menopausia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menopausia);
        }

        // GET: Menopausias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menopausia = await _context.Menopausia.FindAsync(id);
            if (menopausia == null)
            {
                return NotFound();
            }
            return View(menopausia);
        }

        // POST: Menopausias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Menopausia menopausia)
        {
            if (id != menopausia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menopausia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenopausiaExists(menopausia.Id))
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
            return View(menopausia);
        }

        // GET: Menopausias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menopausia = await _context.Menopausia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menopausia == null)
            {
                return NotFound();
            }

            return View(menopausia);
        }

        // POST: Menopausias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menopausia = await _context.Menopausia.FindAsync(id);
            _context.Menopausia.Remove(menopausia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenopausiaExists(int id)
        {
            return _context.Menopausia.Any(e => e.Id == id);
        }
    }
}
