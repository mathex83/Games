using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MathexGaming.Models.Diablo3;
using MathexGaming.Models.FIFA;

namespace MathexGaming.Models
{
	public class Gamer
	{
		[Key]
		public int GamerId { get; set; }
				
		[StringLength(20)]
		public string PSUser { get; set; }		
		
		[StringLength(50)]
		public string PSEmail { get; set; }

		[StringLength(50)]
		public string RealName { get; set; }

		#region D3UserCompletion Many		
		public ICollection<D3UserCompletion> D3UserCompletions { get; set; }
		#endregion		
	}
}
