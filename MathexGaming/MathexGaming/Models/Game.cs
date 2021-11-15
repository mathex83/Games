using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models
{
	public class Game
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		[StringLength(100)]
		public string Name { get; set; }
	}
}
