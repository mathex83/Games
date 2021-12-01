using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models.Diablo3
{
	public class DiabloAchievement
	{
		[Key]
		public int Id { get; set; }

		[Required, StringLength(5)]
		public string CompletedColor { get; set; }

		[Required, StringLength(100)]
		public string AchievementName { get; set; }

		[Required, StringLength(300)]
		public string AchievementText { get; set; }

		[Required, StringLength(20)]
		public string Group { get; set; }

		[StringLength(20)]
		public string SubGroup { get; set; }

		public int SeasonRoll { get; set; }
	}
}
