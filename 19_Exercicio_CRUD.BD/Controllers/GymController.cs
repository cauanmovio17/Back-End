using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19_Exercicio_CRUD.BD.Context;
using _19_Exercicio_CRUD.BD.Models;

namespace _19_Exercicio_CRUD.BD.Controllers
{
    public class GymController : Controller
    {
        private readonly AppDbContext _context;

        public GymController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Gym
        public async Task<IActionResult> Index()
        {
              return _context.Gym != null ? 
                          View(await _context.Gym.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Gym'  is null.");
        }

        // GET: Gym/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Gym == null)
            {
                return NotFound();
            }

            var gym = await _context.Gym
                .FirstOrDefaultAsync(m => m.JogoId == id);
            if (gym == null)
            {
                return NotFound();
            }

            return View(gym);
        }

        // GET: Gym/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gym/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JogoId,Nome,Idade,Patrocinio,Campeonato,Coach,Imagem,Ativo")] Gym gym)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gym);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gym);
        }

        // GET: Gym/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Gym == null)
            {
                return NotFound();
            }

            var gym = await _context.Gym.FindAsync(id);
            if (gym == null)
            {
                return NotFound();
            }
            return View(gym);
        }

        // POST: Gym/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JogoId,Nome,Idade,Patrocinio,Campeonato,Coach,Imagem,Ativo")] Gym gym)
        {
            if (id != gym.JogoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gym);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GymExists(gym.JogoId))
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
            return View(gym);
        }

        // GET: Gym/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Gym == null)
            {
                return NotFound();
            }

            var gym = await _context.Gym
                .FirstOrDefaultAsync(m => m.JogoId == id);
            if (gym == null)
            {
                return NotFound();
            }

            return View(gym);
        }

        // POST: Gym/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Gym == null)
            {
                return Problem("Entity set 'AppDbContext.Gym'  is null.");
            }
            var gym = await _context.Gym.FindAsync(id);
            if (gym != null)
            {
                _context.Gym.Remove(gym);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GymExists(int id)
        {
          return (_context.Gym?.Any(e => e.JogoId == id)).GetValueOrDefault();
        }
    }
}
