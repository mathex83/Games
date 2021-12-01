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
    public class DiabloAchievementsController : Controller
    {
        private readonly MathexGamingContext _context;

        public DiabloAchievementsController(MathexGamingContext context)
        {
            _context = context;
        }

        // GET: DiabloAchievements
        public async Task<IActionResult> D3AchievementHome()
        {
            return View(await _context.DiabloAchievements.ToListAsync());
        }

        // GET: DiabloAchievements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabloAchievement = await _context.DiabloAchievements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diabloAchievement == null)
            {
                return NotFound();
            }

            return View(diabloAchievement);
        }

        // GET: DiabloAchievements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiabloAchievements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompletedColor,AchievementName,AchievementText,Group,SubGroup,SeasonRoll")] DiabloAchievement diabloAchievement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diabloAchievement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(D3AchievementHome));
            }
            return View(diabloAchievement);
        }

        // GET: DiabloAchievements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabloAchievement = await _context.DiabloAchievements.FindAsync(id);
            if (diabloAchievement == null)
            {
                return NotFound();
            }
            return View(diabloAchievement);
        }

        // POST: DiabloAchievements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompletedColor,AchievementName,AchievementText,Group,SubGroup,SeasonRoll")] DiabloAchievement diabloAchievement)
        {
            if (id != diabloAchievement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diabloAchievement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiabloAchievementExists(diabloAchievement.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(D3AchievementHome));
            }
            return View(diabloAchievement);
        }

        // GET: DiabloAchievements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabloAchievement = await _context.DiabloAchievements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diabloAchievement == null)
            {
                return NotFound();
            }

            return View(diabloAchievement);
        }

        // POST: DiabloAchievements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diabloAchievement = await _context.DiabloAchievements.FindAsync(id);
            _context.DiabloAchievements.Remove(diabloAchievement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(D3AchievementHome));
        }

        private bool DiabloAchievementExists(int id)
        {
            return _context.DiabloAchievements.Any(e => e.Id == id);
        }
    }
}
