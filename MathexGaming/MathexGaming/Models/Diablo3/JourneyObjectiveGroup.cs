using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathexGaming.Models.Diablo3
{
	public class JourneyObjectiveGroup
	{
		[Key]
		public int ID { get; set; }

		[Display(Name="Group name"), StringLength(30)]
		public string JourneyObjectiveGroupName { get; set; }
	}
}
