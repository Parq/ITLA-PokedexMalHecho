using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokedexMalHecho.Models;

namespace PokedexMalHecho.Controllers
{
    public class PokemonesController : Controller
    {
        private readonly PokedexMalHechoContext _context;

        public PokemonesController(PokedexMalHechoContext context)
        {
            _context = context;
        }

        // GET: Pokemones
        public async Task<IActionResult> Index()
        {
            var pokedexMalHechoContext = _context.Pokemones.Include(p => p.RegionNavigation).Include(p => p.Tipo1Navigation).Include(p => p.Tipo2Navigation);
            return View(await pokedexMalHechoContext.ToListAsync());
        }

        // GET: Pokemones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemones = await _context.Pokemones
                .Include(p => p.RegionNavigation)
                .Include(p => p.Tipo1Navigation)
                .Include(p => p.Tipo2Navigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokemones == null)
            {
                return NotFound();
            }

            return View(pokemones);
        }

        // GET: Pokemones/Create
        public IActionResult Create()
        {
            ViewData["Region"] = new SelectList(_context.Regiones, "Id", "Nombre");
            ViewData["Tipo1"] = new SelectList(_context.Tipos, "Id", "Nombre");
            ViewData["Tipo2"] = new SelectList(_context.Tipos, "Id", "Nombre");
            return View();
        }

        // POST: Pokemones/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Tipo1,Tipo2,Region,Ataque1,Ataque2,Ataque3,Ataque4")] Pokemones pokemones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokemones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Region"] = new SelectList(_context.Regiones, "Id", "Nombre", pokemones.Region);
            ViewData["Tipo1"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo1);
            ViewData["Tipo2"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo2);
            return View(pokemones);
        }

        // GET: Pokemones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemones = await _context.Pokemones.FindAsync(id);
            if (pokemones == null)
            {
                return NotFound();
            }
            ViewData["Region"] = new SelectList(_context.Regiones, "Id", "Nombre", pokemones.Region);
            ViewData["Tipo1"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo1);
            ViewData["Tipo2"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo2);
            return View(pokemones);
        }

        // POST: Pokemones/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Tipo1,Tipo2,Region,Ataque1,Ataque2,Ataque3,Ataque4")] Pokemones pokemones)
        {
            if (id != pokemones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonesExists(pokemones.Id))
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
            ViewData["Region"] = new SelectList(_context.Regiones, "Id", "Nombre", pokemones.Region);
            ViewData["Tipo1"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo1);
            ViewData["Tipo2"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo2);
            return View(pokemones);
        }

        // GET: Pokemones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemones = await _context.Pokemones
                .Include(p => p.RegionNavigation)
                .Include(p => p.Tipo1Navigation)
                .Include(p => p.Tipo2Navigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokemones == null)
            {
                return NotFound();
            }

            return View(pokemones);
        }

        // POST: Pokemones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokemones = await _context.Pokemones.FindAsync(id);
            _context.Pokemones.Remove(pokemones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonesExists(int id)
        {
            return _context.Pokemones.Any(e => e.Id == id);
        }
    }
}
