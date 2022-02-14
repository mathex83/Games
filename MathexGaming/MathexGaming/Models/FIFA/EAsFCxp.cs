using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.FIFA
{
	public class EAsFCxp
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),Display(Name ="ID")]
		public int EAsFCxpID { get; set; }

		[Display(Name="Next level",Order = -5)]
		public int NextLevel { get; set; }
		[Display(Name = "Threshold")]
		public int XPThreshold { get; set; }
	}
}
