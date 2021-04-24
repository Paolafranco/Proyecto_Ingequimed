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
    public class ParejasController : Controller
    {
        private readonly MainContext _context;

        public ParejasController(MainContext context)
        {
            _context = context;
        }

        // GET: Parejas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pareja.ToListAsync());
        }

        // GET: Parejas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pareja = await _context.Pareja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pareja == null)
            {
                return NotFound();
            }

            return View(pareja);
        }

        // GET: Parejas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parejas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Enfermedades,Anticonceptivo,Impotencia,Ets,HIV,Hvp,Gonorrea,Otros,NombreEnfermedades,NombreAnticonceptivo")] Pareja pareja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pareja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pareja);
        }

        // GET: Parejas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pareja = await _context.Pareja.FindAsync(id);
            if (pareja == null)
            {
                return NotFound();
            }
            return View(pareja);
        }

        // POST: Parejas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Enfermedades,Anticonceptivo,Impotencia,Ets,HIV,Hvp,Gonorrea,Otros,NombreEnfermedades,NombreAnticonceptivo")] Pareja pareja)
        {
            if (id != pareja.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pareja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParejaExists(pareja.Id))
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
            return View(pareja);
        }

        // GET: Parejas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pareja = await _context.Pareja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pareja == null)
            {
                return NotFound();
            }

            return View(pareja);
        }

        // POST: Parejas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pareja = await _context.Pareja.FindAsync(id);
            _context.Pareja.Remove(pareja);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParejaExists(int id)
        {
            return _context.Pareja.Any(e => e.Id == id);
        }
    }
}
