﻿using MathexGaming.Models;
using Microsoft.EntityFrameworkCore;

namespace MathexGaming.Data
{
	public class MathexGamingDbContext : DbContext
	{
		public MathexGamingDbContext(DbContextOptions<MathexGamingDbContext> options) : base(options)
		{ }

		public DbSet<Gamer> Gamers { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<PSTrophy> PSTrophies { get; set; }
		public DbSet<Models.THPS.GameMap> GameMap { get; set; }
		public DbSet<Challenge> Challenges { get; set; }
	}
}
