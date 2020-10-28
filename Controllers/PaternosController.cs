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
    public class PaternosController : Controller
    {
        private readonly MainContext _context;

        public PaternosController(MainContext context)
        {
            _context = context;
        }

        // GET: Paternos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Paterno.ToListAsync());
        }

        // GET: Paternos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paterno = await _context.Paterno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paterno == null)
            {
                return NotFound();
            }

            return View(paterno);
        }

        // GET: Paternos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Paternos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Pariente,Parentesco,Enfermedad")] Paterno paterno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paterno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paterno);
        }

        // GET: Paternos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paterno = await _context.Paterno.FindAsync(id);
            if (paterno == null)
            {
                return NotFound();
            }
            return View(paterno);
        }

        // POST: Paternos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Pariente,Parentesco,Enfermedad")] Paterno paterno)
        {
            if (id != paterno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paterno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaternoExists(paterno.Id))
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
            return View(paterno);
        }

        // GET: Paternos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paterno = await _context.Paterno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paterno == null)
            {
                return NotFound();
            }

            return View(paterno);
        }

        // POST: Paternos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paterno = await _context.Paterno.FindAsync(id);
            _context.Paterno.Remove(paterno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaternoExists(int id)
        {
            return _context.Paterno.Any(e => e.Id == id);
        }
    }
}
