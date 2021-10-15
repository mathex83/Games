using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models
{
	public class Gamer
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		[StringLength(20)]
		public string PSUser { get; set; }
		
		[Required]
		[StringLength(50)]
		public string PSEmail { get; set; }
	}
}
