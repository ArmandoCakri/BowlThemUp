using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BowlThemUp.Data;
using BowlThemUp.Models;

namespace BowlThemUp.Controllers
{
    public class AlleysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlleysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Alleys
        public async Task<IActionResult> Index()
        {
              return _context.Alley != null ? 
                          View(await _context.Alley.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Alley'  is null.");
        }

        // GET: Alleys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Alley == null)
            {
                return NotFound();
            }

            var alley = await _context.Alley
                .FirstOrDefaultAsync(m => m.AlleyID == id);
            if (alley == null)
            {
                return NotFound();
            }

            return View(alley);
        }

        // GET: Alleys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alleys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlleyID,LaneType,LaneCondition,LaneLength")] Alley alley)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alley);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alley);
        }

        // GET: Alleys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Alley == null)
            {
                return NotFound();
            }

            var alley = await _context.Alley.FindAsync(id);
            if (alley == null)
            {
                return NotFound();
            }
            return View(alley);
        }

        // POST: Alleys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlleyID,LaneType,LaneCondition,LaneLength")] Alley alley)
        {
            if (id != alley.AlleyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alley);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlleyExists(alley.AlleyID))
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
            return View(alley);
        }

        // GET: Alleys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Alley == null)
            {
                return NotFound();
            }

            var alley = await _context.Alley
                .FirstOrDefaultAsync(m => m.AlleyID == id);
            if (alley == null)
            {
                return NotFound();
            }

            return View(alley);
        }

        // POST: Alleys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Alley == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Alley'  is null.");
            }
            var alley = await _context.Alley.FindAsync(id);
            if (alley != null)
            {
                _context.Alley.Remove(alley);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlleyExists(int id)
        {
          return (_context.Alley?.Any(e => e.AlleyID == id)).GetValueOrDefault();
        }
    }
}
