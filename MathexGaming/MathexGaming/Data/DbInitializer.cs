using MathexGaming.Models.Diablo3;
using MathexGaming.Models.FIFA;
using System.Linq;
using System.Threading.Tasks;

namespace MathexGaming.Data
{
	public static class DbInitializer
	{
		public static async Task InitializeAsync(MathexGamingContext context)
		{
			context.Database.EnsureCreated();

			// Look for any games.
			if (context.Games.Any())
			{
				return;   // DB has been seeded if this is hit
			}

			foreach (AchievementGroup ag in D3Lists.AchievementGroups)
			{
				context.AchievementGroups.Add(ag);
			}
			await context.SaveChangesAsync();

			foreach (AchievementSubGroup asg in D3Lists.AchievementSubGroups)
			{
				context.AchievementSubGroups.Add(asg);
			}
			await context.SaveChangesAsync();

			foreach (FUTgame f in FIFALists.FUTgames)
			{
				context.FUTGames.Add(f);
			}			
			await context.SaveChangesAsync();			
			
			foreach (User u in FIFALists.Users)
			{
				context.Users.Add(u);
			}
			await context.SaveChangesAsync();

			////Gemmes til jeg finder en løsning med id baseret på UserName - indtil da brug sql
			//foreach (UserCoin uc in FIFALists.UserCoins)
			//{
			//	context.UserCoins.Add(uc);
			//}
			//await context.SaveChangesAsync();

			foreach (EAsFCxp x in FIFALists.Xps)
			{
				context.EAsFCxps.Add(x);
			}			
			await context.SaveChangesAsync();

			
		}
	}
}