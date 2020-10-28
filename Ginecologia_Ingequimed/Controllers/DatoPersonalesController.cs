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
    public class DatoPersonalesController : Controller
    {
        private readonly MainContext _context;

        public DatoPersonalesController(MainContext context)
        {
            _context = context;
        }

        // GET: DatoPersonales
        public async Task<IActionResult> Index()
        {
            return View(await _context.DatoPersonal.ToListAsync());
        }

        // GET: DatoPersonales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoPersonal = await _context.DatoPersonal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoPersonal == null)
            {
                return NotFound();
            }

            return View(datoPersonal);
        }

        // GET: DatoPersonales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DatoPersonales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Edad,Habitos,Patalogías,Alergias,Embarazos,Cesárea,Cirugías")] DatoPersonal datoPersonal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datoPersonal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datoPersonal);
        }

        // GET: DatoPersonales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoPersonal = await _context.DatoPersonal.FindAsync(id);
            if (datoPersonal == null)
            {
                return NotFound();
            }
            return View(datoPersonal);
        }

        // POST: DatoPersonales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Edad,Habitos,Patalogías,Alergias,Embarazos,Cesárea,Cirugías")] DatoPersonal datoPersonal)
        {
            if (id != datoPersonal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datoPersonal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatoPersonalExists(datoPersonal.Id))
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
            return View(datoPersonal);
        }

        // GET: DatoPersonales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoPersonal = await _context.DatoPersonal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoPersonal == null)
            {
                return NotFound();
            }

            return View(datoPersonal);
        }

        // POST: DatoPersonales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datoPersonal = await _context.DatoPersonal.FindAsync(id);
            _context.DatoPersonal.Remove(datoPersonal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatoPersonalExists(int id)
        {
            return _context.DatoPersonal.Any(e => e.Id == id);
        }
    }
}
