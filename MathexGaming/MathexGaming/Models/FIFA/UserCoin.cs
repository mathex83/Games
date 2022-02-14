using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.FIFA
{
	public class UserCoin
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CoinID { get; set; }
		public int Coins { get; set; }

		[Display(Name = "Drafts")]
		public int DraftsBought { get; set; }


		#region Foreign key Users
		public int UserID { get; set; }
		
		[Display(Name = "User")]
		public User User { get; set; }
		#endregion


		#region Foreign key Games		
		public int FUTgameID { get; set; }

		[Display(Name = "Game")]
		public FUTgame FUTgame { get; set; }
		#endregion
	}
}
