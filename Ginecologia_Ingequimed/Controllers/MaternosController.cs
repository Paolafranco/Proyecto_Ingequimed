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
    public class MaternosController : Controller
    {
        private readonly MainContext _context;

        public MaternosController(MainContext context)
        {
            _context = context;
        }

        // GET: Maternos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Materno.ToListAsync());
        }

        // GET: Maternos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materno = await _context.Materno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materno == null)
            {
                return NotFound();
            }

            return View(materno);
        }

        // GET: Maternos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Maternos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Pariente,Parentesco,Enfermedad")] Materno materno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materno);
        }

        // GET: Maternos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materno = await _context.Materno.FindAsync(id);
            if (materno == null)
            {
                return NotFound();
            }
            return View(materno);
        }

        // POST: Maternos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Pariente,Parentesco,Enfermedad")] Materno materno)
        {
            if (id != materno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaternoExists(materno.Id))
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
            return View(materno);
        }

        // GET: Maternos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materno = await _context.Materno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materno == null)
            {
                return NotFound();
            }

            return View(materno);
        }

        // POST: Maternos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materno = await _context.Materno.FindAsync(id);
            _context.Materno.Remove(materno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaternoExists(int id)
        {
            return _context.Materno.Any(e => e.Id == id);
        }
    }
}
