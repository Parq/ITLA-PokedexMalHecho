using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokedexMalHecho.Models;
using PokedexMalHecho.DTO;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using AutoMapper;
using Microsoft.Extensions.FileProviders;

namespace PokedexMalHecho.Controllers
{
    public class PokemonesController : Controller
    {
        private readonly PokedexMalHechoContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        //private readonly IMapper _mapper;

        public PokemonesController(PokedexMalHechoContext context, IHostingEnvironment hostingEnvironment/*, IMapper mapper*/)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
            //this._mapper = mapper;
        }

        // GET: Pokemones
        public async Task<IActionResult> Index(/*string nombrePokemon = null*/)
        {
            /*var pokemonList = _context.Pokemones.AsQueryable();
            if (!string.IsNullOrEmpty(nombrePokemon))
            {
                pokemonList = _context.Pokemones.Where(x => x.Nombre.Contains(nombrePokemon));
            }
            var list = await pokemonList.ToListAsync();
            return View(list);*/

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
        public async Task<IActionResult> Create([Bind("Id,Nombre,Tipo1,Tipo2,Region,Ataque1,Ataque2,Ataque3,Ataque4,Photo")] PokemonesDTO DTO)
        //public async Task<IActionResult> Create(PokemonesDTO DTO)
        //public IActionResult Create(PokemonesDTO DTO)
        {
            //var pokemon = new Pokemones();
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(DTO.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + DTO.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    DTO.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    //if (filePath != null) DTO.Photo.CopyTo(new FileStream(filePath, mode: FileMode.Create));
                }

                //pokemon = _mapper.Map<Pokemones>(DTO);
                //pokemon.Photo = uniqueFileName;
                Pokemones newPokemon = new Pokemones
                {
                    Id = DTO.Id,
                    Nombre = DTO.Nombre,
                    Tipo1 = DTO.Tipo1,
                    Tipo2 = DTO.Tipo2,
                    Region = DTO.Region,
                    Ataque1=DTO.Ataque1,
                    Ataque2=DTO.Ataque2,
                    Ataque3=DTO.Ataque3,
                    Ataque4=DTO.Ataque4,
                    Photo=uniqueFileName
                };
                _context.Add(newPokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(/*nameof(Index)*/ "index",new { id = newPokemon.Id});
            }
            /*ViewData["Region"] = new SelectList(_context.Regiones, "Id", "Nombre", pokemones.Region);
            ViewData["Tipo1"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo1);
            ViewData["Tipo2"] = new SelectList(_context.Tipos, "Id", "Nombre", pokemones.Tipo2);*/
            return View(/*DTOpokemones*/);
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

            var pokemonesDTO = new PokemonesDTO()
            {
                Id = pokemones.Id,
                Nombre = pokemones.Nombre,
                Region = pokemones.Region,
                Tipo1 = pokemones.Tipo1,
                Tipo2 = pokemones.Tipo2,
                Ataque1 = pokemones.Ataque1,
                Ataque2 = pokemones.Ataque2,
                Ataque3 = pokemones.Ataque3,
                Ataque4 = pokemones.Ataque4
                //Photo=pokemones.Photo
            };

            return View(pokemonesDTO);
        }

        // POST: Pokemones/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Tipo1,Tipo2,Region,Ataque1,Ataque2,Ataque3,Ataque4,Photo")] /*Pokemones pokemones*/ PokemonesDTO dTO)
        {
            if (id != dTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var pokemon = await _context.Pokemones.FirstOrDefaultAsync(d => d.Id == dTO.Id);

                    string uniqueName = null;
                    if (dTO.Photo != null)
                    {
                        string folderPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        uniqueName = Guid.NewGuid().ToString() + "_" + dTO.Photo.FileName;
                        string filePath = Path.Combine(folderPath, uniqueName);

                        string filePathDelete = Path.Combine(folderPath, pokemon.Photo);

                        if (!string.IsNullOrEmpty(pokemon.Photo))
                        {
                            if (System.IO.File.Exists(filePathDelete))
                            {
                                var fileInfo = new System.IO.FileInfo(filePathDelete);
                                fileInfo.Delete();
                            }
                        }
                        if (filePath != null) dTO.Photo.CopyTo(new FileStream(filePath, mode: FileMode.Create));
                    }
                    pokemon.Id = dTO.Id;
                    pokemon.Region = dTO.Region;
                    pokemon.Tipo1 = dTO.Tipo1;
                    pokemon.Tipo2 = dTO.Tipo2;
                    pokemon.Ataque1 = dTO.Ataque1;
                    pokemon.Ataque2 = dTO.Ataque2;
                    pokemon.Ataque3 = dTO.Ataque3;
                    pokemon.Ataque4 = dTO.Ataque4;
                    pokemon.Photo = uniqueName;

                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonesExists(dTO.Id))
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
            return View(dTO);

            /*
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
            return View(pokemones);*/
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
