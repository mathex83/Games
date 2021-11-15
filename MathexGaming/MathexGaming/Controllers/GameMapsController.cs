using MathexGaming.Data;
using MathexGaming.Models.THPS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MathexGaming.Controllers
{
	public class GameMapsController : Controller
    {
        private readonly MathexGamingContext _context;

        public GameMapsController(MathexGamingContext context)
        {
            _context = context;
        }

        // GET: GameMaps
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameMap.ToListAsync());
        }

        // GET: GameMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameMap = await _context.GameMap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameMap == null)
            {
                return NotFound();
            }

            return View(gameMap);
        }

        // GET: GameMaps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameMaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,RWLocation")] GameMap gameMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameMap);
        }

        // GET: GameMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameMap = await _context.GameMap.FindAsync(id);
            if (gameMap == null)
            {
                return NotFound();
            }
            return View(gameMap);
        }

        // POST: GameMaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,RWLocation")] GameMap gameMap)
        {
            if (id != gameMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameMapExists(gameMap.Id))
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
            return View(gameMap);
        }

        // GET: GameMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameMap = await _context.GameMap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameMap == null)
            {
                return NotFound();
            }

            return View(gameMap);
        }

        // POST: GameMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameMap = await _context.GameMap.FindAsync(id);
            _context.GameMap.Remove(gameMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameMapExists(int id)
        {
            return _context.GameMap.Any(e => e.Id == id);
        }
    }
}
