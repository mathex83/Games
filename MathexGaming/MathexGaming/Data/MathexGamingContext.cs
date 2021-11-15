using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MathexGaming.Models;
using MathexGaming.Models.THPS;

namespace MathexGaming.Data
{
	public class MathexGamingContext : IdentityDbContext
	{
		public MathexGamingContext(DbContextOptions<MathexGamingContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Game { get; set; }
		public DbSet<MathexGaming.Models.Challenge> Challenge { get; set; }
		public DbSet<MathexGaming.Models.THPS.GameMap> GameMap { get; set; }
	}
}
