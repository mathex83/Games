using MathexGaming.Data;
using MathexGaming.Models.FIFA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathexGaming.Controllers.FIFA
{
	public class UserCoinsController : Controller
    {
        private readonly MathexGamingContext _context;

        public UserCoinsController(MathexGamingContext context)
        {
            _context = context;
        }

        // GET: UserCoins
        public async Task<IActionResult> UserCoinsList(string sortOrder)
        {
            List<UserCoin> dbList = new List<UserCoin>();
            IQueryable<UserCoin> userCoins = from uc in _context.UserCoins
                                             where uc.FUTgameID == 19      //Change to view 17,18,19
                                             select uc;
            foreach (UserCoin uco in userCoins)
            {
                dbList.Add(uco);
            }
            ViewData["sum17"] = (from uc in dbList where uc.FUTgameID == 17 select uc.Coins).ToList().Sum();
            ViewData["d17"] = (from d in dbList where d.FUTgameID == 17 select d.DraftsBought).ToList().Sum();

            ViewData["sum18"] = (from uc in dbList where uc.FUTgameID == 18 select uc.Coins).ToList().Sum();
            ViewData["d18"] = (from d in dbList where d.FUTgameID == 18 select d.DraftsBought).ToList().Sum();

            ViewData["sum19"] = (from uc in dbList where uc.FUTgameID == 19 select uc.Coins).ToList().Sum();
            ViewData["d19"] = (from d in dbList where d.FUTgameID == 19 select d.DraftsBought).ToList().Sum();

            ViewData["GameSortParam"] =
                    string.IsNullOrEmpty(sortOrder) || sortOrder == "game_desc" ? "game" : "game_desc";

            switch (sortOrder)
            {
                case "game_desc":
                    userCoins = userCoins.OrderByDescending(uc => uc.FUTgameID);
                    break;
                default:
                    userCoins = userCoins.OrderBy(uc => uc.FUTgameID);
                    break;
            }

            return View(await userCoins.AsNoTracking()
                .Include(u => u.FUTgame)
                .Include(u => u.User)
                .ToListAsync());
            //var mathexGamingContext = _context.UserCoins.Include(u => u.FUTgame);
            //return View(await mathexGamingContext.ToListAsync());
        }
        
        // GET: UserCoins/Create
        public IActionResult Create()
        {
            ViewData["FUTgameID"] = new SelectList(_context.FUTGames, "FUTgameID", "FUTgameID");
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserName", "UserID");
            return View();
        }

        // POST: UserCoins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoinID,Coins,DraftsBought,UserID,FUTgameID")] UserCoin userCoin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userCoin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserCoinsList));
            }
            ViewData["FUTgameID"] = new SelectList(_context.FUTGames, "FUTgameID", "FUTgameID", userCoin.FUTgameID);
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", userCoin.UserID);
            return View(userCoin);
        }

        // GET: UserCoins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCoin = await _context.UserCoins.FindAsync(id);
            if (userCoin == null)
            {
                return NotFound();
            }
            ViewData["FUTgameID"] = new SelectList(_context.FUTGames, "FUTgameID", "FUTgameID", userCoin.FUTgameID);
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserName", userCoin.UserID);
            return View(userCoin);
        }

        // POST: UserCoins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoinID,Coins,DraftsBought,UserID,FUTgameID")] UserCoin userCoin)
        {
            if (id != userCoin.CoinID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userCoin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserCoinExists(userCoin.CoinID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(UserCoinsList));
            }
            ViewData["FUTgameID"] = new SelectList(_context.FUTGames, "FUTgameID", "FUTgameID", userCoin.FUTgameID);
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", userCoin.UserID);
            return View(userCoin);
        }

        // GET: UserCoins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCoin = await _context.UserCoins
                .Include(u => u.FUTgame)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.CoinID == id);
            if (userCoin == null)
            {
                return NotFound();
            }

            return View(userCoin);
        }

        // POST: UserCoins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userCoin = await _context.UserCoins.FindAsync(id);
            _context.UserCoins.Remove(userCoin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserCoinsList));
        }

        private bool UserCoinExists(int id)
        {
            return _context.UserCoins.Any(e => e.CoinID == id);
        }
    }
}
