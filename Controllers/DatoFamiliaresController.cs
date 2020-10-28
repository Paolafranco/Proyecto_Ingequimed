using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ginecologia_Ingequimed.Data;
using Ginecologia_Ingequimed.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Ginecologia_Ingequimed.ViewModel;

namespace Ginecologia_Ingequimed.Controllers
{
    public class DatoFamiliaresController : Controller
    {
        private readonly MainContext _context;

        public DatoFamiliaresController(MainContext context)
        {
            _context = context;
        }

        // GET: DatoFamiliares
        public async Task<IActionResult> Index()
        {
            return View(await _context.DatoFamiliar.ToListAsync());
        }

        // GET: DatoFamiliares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoFamiliar = await _context.DatoFamiliar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoFamiliar == null)
            {
                return NotFound();
            }

            return View(datoFamiliar);
        }

        // GET: DatoFamiliares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DatoFamiliares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DatosViewModel producto)
        {
            if (ModelState.IsValid)
            {

                DatoFamiliar productos = new DatoFamiliar();

                productos.ImagenProducto = ConvertirArregloByte(producto.ImagenProducto);

                _context.Add(productos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        private byte[] ConvertirArregloByte(IFormFile formFile)
        {
            if (formFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    formFile.CopyTo(memoryStream);
                    var tamanoMaximo = 2097152; //si el archivo es mas grande usar streaming
                    if (memoryStream.Length < tamanoMaximo)
                        return memoryStream.ToArray();
                }
            }
            return null;
        }

        // GET: DatoFamiliares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoFamiliar = await _context.DatoFamiliar.FindAsync(id);
            if (datoFamiliar == null)
            {
                return NotFound();
            }
            return View(datoFamiliar);
        }

        // POST: DatoFamiliares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagenProducto")] DatoFamiliar datoFamiliar)
        {
            if (id != datoFamiliar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datoFamiliar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatoFamiliarExists(datoFamiliar.Id))
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
            return View(datoFamiliar);
        }

        // GET: DatoFamiliares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoFamiliar = await _context.DatoFamiliar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoFamiliar == null)
            {
                return NotFound();
            }

            return View(datoFamiliar);
        }

        // POST: DatoFamiliares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datoFamiliar = await _context.DatoFamiliar.FindAsync(id);
            _context.DatoFamiliar.Remove(datoFamiliar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatoFamiliarExists(int id)
        {
            return _context.DatoFamiliar.Any(e => e.Id == id);
        }
    }
}
