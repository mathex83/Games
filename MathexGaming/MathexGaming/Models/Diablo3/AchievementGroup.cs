using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.Diablo3
{
	public class AchievementGroup
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AchievementGroupID { get; set; }

		[Display(Name="Group name"), StringLength(30)]
		public string AchievementGroupName { get; set; }

		public ICollection<AchievementSubGroup> AchievementSubGroups { get; set; }
	}
}
