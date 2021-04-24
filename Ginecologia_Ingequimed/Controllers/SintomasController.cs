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
    public class SintomasController : Controller
    {
        private readonly MainContext _context;

        public SintomasController(MainContext context)
        {
            _context = context;
        }

        // GET: Sintomas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sintoma.ToListAsync());
        }

        // GET: Sintomas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sintoma = await _context.Sintoma
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sintoma == null)
            {
                return NotFound();
            }

            return View(sintoma);
        }

        // GET: Sintomas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sintomas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fin_del_Periodo,Días_de_Periodo,Pastillas,Inyecciones,Otros_Cuidados,Acto_Sexual,Sintomas,Estado_de_Ánimo,Notas")] Sintoma sintoma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sintoma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sintoma);
        }

        // GET: Sintomas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sintoma = await _context.Sintoma.FindAsync(id);
            if (sintoma == null)
            {
                return NotFound();
            }
            return View(sintoma);
        }

        // POST: Sintomas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fin_del_Periodo,Días_de_Periodo,Pastillas,Inyecciones,Otros_Cuidados,Acto_Sexual,Sintomas,Estado_de_Ánimo,Notas")] Sintoma sintoma)
        {
            if (id != sintoma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sintoma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SintomaExists(sintoma.Id))
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
            return View(sintoma);
        }

        // GET: Sintomas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sintoma = await _context.Sintoma
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sintoma == null)
            {
                return NotFound();
            }

            return View(sintoma);
        }

        // POST: Sintomas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sintoma = await _context.Sintoma.FindAsync(id);
            _context.Sintoma.Remove(sintoma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SintomaExists(int id)
        {
            return _context.Sintoma.Any(e => e.Id == id);
        }
    }
}
