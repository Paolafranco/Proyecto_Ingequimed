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
    public class SaludsController : Controller
    {
        private readonly MainContext _context;

        public SaludsController(MainContext context)
        {
            _context = context;
        }

        // GET: Saluds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Salud.ToListAsync());
        }

        // GET: Saluds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salud = await _context.Salud
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salud == null)
            {
                return NotFound();
            }

            return View(salud);
        }

        // GET: Saluds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Saluds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fitness,Alimentación,Embarazo")] Salud salud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salud);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salud);
        }

        // GET: Saluds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salud = await _context.Salud.FindAsync(id);
            if (salud == null)
            {
                return NotFound();
            }
            return View(salud);
        }

        // POST: Saluds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fitness,Alimentación,Embarazo")] Salud salud)
        {
            if (id != salud.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salud);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaludExists(salud.Id))
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
            return View(salud);
        }

        // GET: Saluds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salud = await _context.Salud
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salud == null)
            {
                return NotFound();
            }

            return View(salud);
        }

        // POST: Saluds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salud = await _context.Salud.FindAsync(id);
            _context.Salud.Remove(salud);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaludExists(int id)
        {
            return _context.Salud.Any(e => e.Id == id);
        }
    }
}
