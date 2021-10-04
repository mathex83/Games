using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models
{
	public class Gamer
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string PSUser { get; set; }
		[Required]
		public string PSEmail { get; set; }
	}
}
