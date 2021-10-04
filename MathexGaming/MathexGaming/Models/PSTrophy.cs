using System.ComponentModel.DataAnnotations;

namespace MathexGaming.Models
{
	public class PSTrophy
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string EName { get; set; }
		[Required]
		public string EDescription { get; set; }

		public string Dname { get; set; }

		public string DDescription { get; set; }
	}
}
