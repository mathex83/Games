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
						
		[StringLength(200)]
		public string SkaterImage { get; set; }


		#region Foreign key
		public int GameId { get; set; }
		public Game Game { get; set; } 
		#endregion
	}
}
