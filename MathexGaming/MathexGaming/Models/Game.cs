using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models
{
	public class Game
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
	}
}
