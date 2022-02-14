using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.FIFA
{
	public class FUTgame
	{
		[Key, Column("FUTgame"), Display(Name="Game"),
			DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int FUTgameID { get; set; }
				
		#region UserCoin many
		public ICollection<UserCoin> UserCoins { get; set; }
		#endregion
	}
}
