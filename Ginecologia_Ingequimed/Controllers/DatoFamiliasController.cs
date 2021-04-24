using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ginecologia_Ingequimed.Data;
using Ginecologia_Ingequimed.Models;
using Ginecologia_Ingequimed.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Ginecologia_Ingequimed.Controllers
{
    public class DatoFamiliasController : Controller
    {
        private readonly MainContext _context;

        public DatoFamiliasController(MainContext context)
        {
            _context = context;
        }

        // GET: DatoFamilias
        public async Task<IActionResult> Index()
        {
            return View(await _context.DatoFamily.ToListAsync());
        }

        // GET: DatoFamilias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoFamily = await _context.DatoFamily
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoFamily == null)
            {
                return NotFound();
            }

            return View(datoFamily);
        }

        // GET: DatoFamilias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DatoFamilias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaViewModel modelo)//[Bind("Id,Nombre,Apellido")]
        {
            if (ModelState.IsValid)
            {
                // persona.Id = Guid.NewGuid();
               DatoFamily persona = new DatoFamily
               {
                    Nombre = modelo.Nombre,
                    Apellido = modelo.Apellido,
                    FotografiaPerfil = await ArchivoSubidoAsync(modelo.FotografiaPerfil)

                };
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        private async Task<byte[]> ArchivoSubidoAsync(IFormFile fotografiaPerfil)
        {
            if (fotografiaPerfil == null) return null;
            var memoryStream = new MemoryStream();
            await fotografiaPerfil.CopyToAsync(memoryStream);
            if (memoryStream.Length < 2097152) return memoryStream.ToArray();
            return null;
        }

        // GET: DatoFamilias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoFamily = await _context.DatoFamily.FindAsync(id);
            if (datoFamily == null)
            {
                return NotFound();
            }
            return View(datoFamily);
        }

        // POST: DatoFamilias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,FotografiaPerfil")] DatoFamily datoFamily)
        {
            if (id != datoFamily.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datoFamily);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatoFamilyExists(datoFamily.Id))
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
            return View(datoFamily);
        }

        // GET: DatoFamilias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoFamily = await _context.DatoFamily
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoFamily == null)
            {
                return NotFound();
            }

            return View(datoFamily);
        }

        // POST: DatoFamilias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datoFamily = await _context.DatoFamily.FindAsync(id);
            _context.DatoFamily.Remove(datoFamily);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatoFamilyExists(int id)
        {
            return _context.DatoFamily.Any(e => e.Id == id);
        }
    }
}
