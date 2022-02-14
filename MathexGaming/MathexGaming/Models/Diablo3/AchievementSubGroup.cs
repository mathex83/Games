using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.Diablo3
{
	public class AchievementSubGroup
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AchievementSubGroupID { get; set; }

		[Display(Name = "Subgroup name"), StringLength(30)]
		public string AchievementSubGroupName { get; set; }

		public int AchievementGroupId { get; set; }
		public AchievementGroup AchievementGroup { get; set; }
	}
}
