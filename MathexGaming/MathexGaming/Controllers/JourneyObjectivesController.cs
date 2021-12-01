using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MathexGaming.Data;
using MathexGaming.Models.Diablo3;

namespace MathexGaming.Controllers
{
    public class JourneyObjectivesController : Controller
    {
        private readonly MathexGamingContext _context;

        public JourneyObjectivesController(MathexGamingContext context)
        {
            _context = context;
        }

        // GET: JourneyObjectives
        public async Task<IActionResult> JourneyHome()
        {
            return View(await _context.JourneyObjectives.ToListAsync());
        }

        // GET: JourneyObjectives/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journeyObjective = await _context.JourneyObjectives
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journeyObjective == null)
            {
                return NotFound();
            }

            return View(journeyObjective);
        }

        // GET: JourneyObjectives/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JourneyObjectives/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ObjectiveName,Description,Chapter,Season,Group,CompletedColor")] JourneyObjective journeyObjective)
        {
            if (ModelState.IsValid)
            {
                _context.Add(journeyObjective);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(JourneyHome));
            }
            return View(journeyObjective);
        }

        // GET: JourneyObjectives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journeyObjective = await _context.JourneyObjectives.FindAsync(id);
            if (journeyObjective == null)
            {
                return NotFound();
            }
            return View(journeyObjective);
        }

        // POST: JourneyObjectives/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ObjectiveName,Description,Chapter,Season,Group,CompletedColor")] JourneyObjective journeyObjective)
        {
            if (id != journeyObjective.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(journeyObjective);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JourneyObjectiveExists(journeyObjective.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(JourneyHome));
            }
            return View(journeyObjective);
        }

        // GET: JourneyObjectives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journeyObjective = await _context.JourneyObjectives
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journeyObjective == null)
            {
                return NotFound();
            }

            return View(journeyObjective);
        }

        // POST: JourneyObjectives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var journeyObjective = await _context.JourneyObjectives.FindAsync(id);
            _context.JourneyObjectives.Remove(journeyObjective);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(JourneyHome));
        }

        private bool JourneyObjectiveExists(int id)
        {
            return _context.JourneyObjectives.Any(e => e.Id == id);
        }
    }
}
