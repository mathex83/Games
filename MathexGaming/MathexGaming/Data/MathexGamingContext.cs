using Microsoft.EntityFrameworkCore;
using MathexGaming.Models;
using MathexGaming.Models.Diablo3;
using MathexGaming.Models.THPS;

namespace MathexGaming.Data
{
	public class MathexGamingContext : DbContext
	{
		public MathexGamingContext(DbContextOptions<MathexGamingContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Games { get; set; }
		public DbSet<Challenge> Challenges { get; set; }
		public DbSet<GameMap> GameMaps { get; set; }
		public DbSet<DiabloAchievement> DiabloAchievements { get; set; }
		public DbSet<JourneyObjectiveGroup> JourneyObjectiveGroups { get; set; }
		public DbSet<JourneyObjective> JourneyObjectives { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DiabloAchievement>()
				.HasData(
				#region Season 24
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Boss Mode",
					AchievementText = "Kill all bosses (except Vidian) in 20 mins",
					Group = "ScConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Worlds Apart",
					AchievementText = "Hardcore: Kill all bosses (except Vidian) in 20 mins",
					Group = "HcConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "On A Good Day",
					AchievementText = "3x Legendary Gem 65",
					Group = "ScConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "I Can't Stop",
					AchievementText = "Hardcore: 3x Legendary Gem 65",
					Group = "HcConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Curses!",
					AchievementText = "350 kills Cursed Peat (Act 5/Paths Of The Drowned)",
					Group = "ScConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Stars Align",
					AchievementText = "Hardcore: 350 kills Cursed Peat (Act 5/Paths Of The Drowned",
					Group = "HcConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "The Thrill",
					AchievementText = "GR45 No Set Items",
					Group = "ScConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Super Human",
					AchievementText = "Hardcore: GR45 No Set Items",
					Group = "HcConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Years Of War",
					AchievementText = "GR55 6 different 6-piece set bonuses",
					Group = "ScConquests",
					SeasonRoll = 24
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Dynasty",
					AchievementText = "Hardcore: GR55 6 different 6-piece set bonuses",
					Group = "HcConquests",
					SeasonRoll = 24
				}
				#endregion				
				,				
				#region Season 23
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Boss Mode",
					AchievementText = "Kill all bosses (except Vidian) in 20 mins",
					Group = "ScConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Worlds Apart",
					AchievementText = "Hardcore: Kill all bosses (except Vidian) in 20 mins",
					Group = "HcConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Avarice",
					AchievementText = "50 mio in a single streak",
					Group = "ScConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Avaritia",
					AchievementText = "Hardcore: 50 mio in a single streak",
					Group = "HcConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Speed Demon",
					AchievementText = "T10 rift < 2min",
					Group = "ScConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Need For Speed",
					AchievementText = "Hardcore: T10 rift < 2min",
					Group = "HcConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Divinity",
					AchievementText = "GR75+ Solo",
					Group = "ScConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Lionhearted",
					AchievementText = "Hardcore: GR75+ Solo",
					Group = "HcConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Masters Of The Universe",
					AchievementText = "8 set dungeons mastered",
					Group = "ScConquests",
					SeasonRoll = 23
				},
				new DiabloAchievement
				{
					CompletedColor = "red",
					AchievementName = "Master Of Sets",
					AchievementText = "Hardcore: 8 set dungeons mastered",
					Group = "HcConquests",
					SeasonRoll = 23
				}
				#endregion
				);
			modelBuilder.Entity<JourneyObjectiveGroup>()
				.HasData(
					new JourneyObjectiveGroup { JourneyObjectiveGroupName = "Bosses" }
					, new JourneyObjectiveGroup { JourneyObjectiveGroupName = "Kanai's Cube" }
				);
		}
	}
}
