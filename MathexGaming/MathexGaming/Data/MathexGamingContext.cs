using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MathexGaming.Models;

namespace MathexGaming.Data
{
	public class MathexGamingContext : IdentityDbContext
	{
		public MathexGamingContext(DbContextOptions<MathexGamingContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Game { get; set; }
	}
}
