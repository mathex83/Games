using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.FIFA
{
	public class User
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string PS4RealName { get; set; }

		/// <summary>
		/// Foreign key many
		/// </summary>
		public ICollection<UserCoin> UserCoins { get; set; }
	}
}
