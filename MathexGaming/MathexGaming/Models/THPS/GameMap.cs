using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.THPS
{
	public class GameMap
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public string RWLocation { get; set; }
		[Required]
		public List<Challenge> GameMapChallenges { get; set; }
	}
}
