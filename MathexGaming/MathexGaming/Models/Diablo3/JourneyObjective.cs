using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.Diablo3
{
	public class JourneyObjective
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string ObjectiveName { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Chapter { get; set; }

		[Required]
		public int Season { get; set; }

		[Required]
		public string Group { get; set; }

		[Required]
		public string CompletedColor { get; set; }
	}
}
