using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models
{
	public class Gamer
	{
		[Key]
		public int Id { get; set; }
				
		[StringLength(20)]
		public string PSUser { get; set; }		
		
		[StringLength(50)]
		public string PSEmail { get; set; }
	}
}
