using MathexGaming.Models;
using MathexGaming.Models.Diablo3;
using MathexGaming.Models.FIFA;
using MathexGaming.Models.THPS;
using Microsoft.EntityFrameworkCore;

namespace MathexGaming.Data
{
	public class MathexGamingContext : DbContext
	{
		public MathexGamingContext(DbContextOptions<MathexGamingContext> options)
			: base(options)
		{
		}
		public DbSet<Gamer> Gamers { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<FUTgame> FUTGames { get; set; }
		public DbSet<UserCoin> UserCoins { get; set; }
		public DbSet<EAsFCxp> EAsFCxps { get; set; }
		public DbSet<Challenge> Challenges { get; set; }
		public DbSet<GameMap> GameMaps { get; set; }
		public DbSet<D3Achievement> DiabloAchievements { get; set; }
		public DbSet<AchievementGroup> AchievementGroups { get; set; }
		public DbSet<AchievementSubGroup> AchievementSubGroups { get; set; }
		public DbSet<JourneyObjective> JourneyObjectives { get; set; }
		public DbSet<User> Users { get; set; }		

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{

		//}
	}
}
