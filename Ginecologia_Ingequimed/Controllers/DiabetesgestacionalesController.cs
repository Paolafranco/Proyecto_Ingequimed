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
    public class DiabetesgestacionalesController : Controller
    {
        private readonly MainContext _context;

        public DiabetesgestacionalesController(MainContext context)
        {
            _context = context;
        }

        // GET: Diabetesgestacionales
        public async Task<IActionResult> Index()
        {
            return View(await _context.Diabetesgestacional.ToListAsync());
        }

        // GET: Diabetesgestacionales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabetesgestacional = await _context.Diabetesgestacional
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diabetesgestacional == null)
            {
                return NotFound();
            }

            return View(diabetesgestacional);
        }

        // GET: Diabetesgestacionales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Diabetesgestacionales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Diabetesgestacional diabetesgestacional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diabetesgestacional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diabetesgestacional);
        }

        // GET: Diabetesgestacionales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabetesgestacional = await _context.Diabetesgestacional.FindAsync(id);
            if (diabetesgestacional == null)
            {
                return NotFound();
            }
            return View(diabetesgestacional);
        }

        // POST: Diabetesgestacionales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Diabetesgestacional diabetesgestacional)
        {
            if (id != diabetesgestacional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diabetesgestacional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiabetesgestacionalExists(diabetesgestacional.Id))
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
            return View(diabetesgestacional);
        }

        // GET: Diabetesgestacionales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabetesgestacional = await _context.Diabetesgestacional
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diabetesgestacional == null)
            {
                return NotFound();
            }

            return View(diabetesgestacional);
        }

        // POST: Diabetesgestacionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diabetesgestacional = await _context.Diabetesgestacional.FindAsync(id);
            _context.Diabetesgestacional.Remove(diabetesgestacional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiabetesgestacionalExists(int id)
        {
            return _context.Diabetesgestacional.Any(e => e.Id == id);
        }
    }
}
