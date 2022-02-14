using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.Diablo3
{
	public class JourneyObjective
	{
		[Key]
		public int Id { get; set; }

		[Required, StringLength(30)]
		public string ObjectiveName { get; set; }

		[Required, StringLength(200)]
		public string Description { get; set; }

		[Required, StringLength(10)]
		public string Chapter { get; set; }

		[Required]
		public int Season { get; set; }

		[Required]
		public string Group { get; set; }
	}
}
