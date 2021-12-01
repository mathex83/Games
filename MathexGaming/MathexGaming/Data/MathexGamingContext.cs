using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MathexGaming.Models;
using MathexGaming.Models.THPS;
using MathexGaming.Models.Diablo3;

namespace MathexGaming.Data
{
	public class MathexGamingContext : IdentityDbContext
	{
		public MathexGamingContext(DbContextOptions<MathexGamingContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Game { get; set; }
		public DbSet<Challenge> Challenge { get; set; }
		public DbSet<GameMap> GameMap { get; set; }
		public DbSet<DiabloAchievement> DiabloAchievements { get; set; }
		public DbSet<JourneyObjective> JourneyObjectives { get; set; }
	}
}
