using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MathexGaming.Models.Diablo3
{
	public class D3UserCompletion
	{
		[Key]
		public int D3UserCompletionID { get; set; }

		[Required, StringLength(5)]
		public string CompletedColor { get; set; }

		#region Foreign key Gamer
		[Display(Name = "Gamer")]
		public int? GamerID { get; set; }
		public Gamer Gamer { get; set; }
		#endregion
	}
}
