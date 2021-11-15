using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models
{
	public class PSTrophy
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Game")]
		public int GameId { get; set; }

		[Required]
		[StringLength(50)]
		public string EngName { get; set; }

		[Required]
		[StringLength(200)]
		public string EngDescription { get; set; }

		[StringLength(50)]
		public string DenName { get; set; }

		[StringLength(200)]
		public string DenDescription { get; set; }

		[StringLength(200)]
		public string PSTrophiesUri { get; set; }

		[StringLength(6)]
		//1=platin, 2=gold, 3=silver, 4=bronze
		public int TrophyType { get; set; }
	}
}
