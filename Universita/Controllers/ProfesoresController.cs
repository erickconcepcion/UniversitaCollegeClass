using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Servuniv.Data;
using Servuniv.Data.Entities;

namespace Universita.Controllers
{
    public class ProfesoresController : Controller
    {
        private readonly ServunivContext _context;

        public ProfesoresController(ServunivContext context)
        {
            _context = context;
        }

        // GET: Profesores
        public async Task<IActionResult> Index()
        {
            var servunivContext = _context.Profesores.Include(p => p.Condiciones).Include(p => p.ProfesoresTipos);
            return View(await servunivContext.ToListAsync());
        }

        // GET: Profesores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesores = await _context.Profesores
                .Include(p => p.Condiciones)
                .Include(p => p.ProfesoresTipos)
                .FirstOrDefaultAsync(m => m.Idprofesor == id);
            if (profesores == null)
            {
                return NotFound();
            }

            return View(profesores);
        }

        // GET: Profesores/Create
        public IActionResult Create()
        {
            ViewData["Idcondicion"] = new SelectList(_context.Condiciones, "Idcondicion", "Condicion");
            ViewData["Idtipodeprofesor"] = new SelectList(_context.ProfesoresTipos, "Idtipodeprofesor", "Tipodeprofesor");
            return View();
        }

        // POST: Profesores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idprofesor,Identificacion,Nombres,Apellidos,Nacimiento,Ingreso,Trabaja,Idtipodeprofesor,Idcondicion")] Profesores profesores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcondicion"] = new SelectList(_context.Condiciones, "Idcondicion", "Condicion", profesores.Idcondicion);
            ViewData["Idtipodeprofesor"] = new SelectList(_context.ProfesoresTipos, "Idtipodeprofesor", "Tipodeprofesor", profesores.Idtipodeprofesor);
            return View(profesores);
        }

        // GET: Profesores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesores = await _context.Profesores.FindAsync(id);
            if (profesores == null)
            {
                return NotFound();
            }
            ViewData["Idcondicion"] = new SelectList(_context.Condiciones, "Idcondicion", "Condicion", profesores.Idcondicion);
            ViewData["Idtipodeprofesor"] = new SelectList(_context.ProfesoresTipos, "Idtipodeprofesor", "Tipodeprofesor", profesores.Idtipodeprofesor);
            return View(profesores);
        }

        // POST: Profesores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idprofesor,Identificacion,Nombres,Apellidos,Nacimiento,Ingreso,Trabaja,Idtipodeprofesor,Idcondicion")] Profesores profesores)
        {
            if (id != profesores.Idprofesor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesoresExists(profesores.Idprofesor))
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
            ViewData["Idcondicion"] = new SelectList(_context.Condiciones, "Idcondicion", "Condicion", profesores.Idcondicion);
            ViewData["Idtipodeprofesor"] = new SelectList(_context.ProfesoresTipos, "Idtipodeprofesor", "Tipodeprofesor", profesores.Idtipodeprofesor);
            return View(profesores);
        }

        // GET: Profesores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesores = await _context.Profesores
                .Include(p => p.Condiciones)
                .Include(p => p.ProfesoresTipos)
                .FirstOrDefaultAsync(m => m.Idprofesor == id);
            if (profesores == null)
            {
                return NotFound();
            }

            return View(profesores);
        }

        // POST: Profesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profesores = await _context.Profesores.FindAsync(id);
            _context.Profesores.Remove(profesores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesoresExists(int id)
        {
            return _context.Profesores.Any(e => e.Idprofesor == id);
        }
    }
}
