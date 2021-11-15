using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.THPS
{
	public class Skater
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		[StringLength(30)]
		public string Name { get; set; }
		
		[ForeignKey("Game")]
		public int GameId { get; set; }
		
		[StringLength(200)]
		public string SkaterImage { get; set; }
	}
}
