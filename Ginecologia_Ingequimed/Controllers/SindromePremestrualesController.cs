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
    public class SindromePremestrualesController : Controller
    {
        private readonly MainContext _context;

        public SindromePremestrualesController(MainContext context)
        {
            _context = context;
        }

        // GET: SindromePremestruales
        public async Task<IActionResult> Index()
        {
            return View(await _context.SindromePremestrual.ToListAsync());
        }

        // GET: SindromePremestruales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sindromePremestrual = await _context.SindromePremestrual
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sindromePremestrual == null)
            {
                return NotFound();
            }

            return View(sindromePremestrual);
        }

        // GET: SindromePremestruales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SindromePremestruales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] SindromePremestrual sindromePremestrual)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sindromePremestrual);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sindromePremestrual);
        }

        // GET: SindromePremestruales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sindromePremestrual = await _context.SindromePremestrual.FindAsync(id);
            if (sindromePremestrual == null)
            {
                return NotFound();
            }
            return View(sindromePremestrual);
        }

        // POST: SindromePremestruales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] SindromePremestrual sindromePremestrual)
        {
            if (id != sindromePremestrual.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sindromePremestrual);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SindromePremestrualExists(sindromePremestrual.Id))
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
            return View(sindromePremestrual);
        }

        // GET: SindromePremestruales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sindromePremestrual = await _context.SindromePremestrual
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sindromePremestrual == null)
            {
                return NotFound();
            }

            return View(sindromePremestrual);
        }

        // POST: SindromePremestruales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sindromePremestrual = await _context.SindromePremestrual.FindAsync(id);
            _context.SindromePremestrual.Remove(sindromePremestrual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SindromePremestrualExists(int id)
        {
            return _context.SindromePremestrual.Any(e => e.Id == id);
        }
    }
}
