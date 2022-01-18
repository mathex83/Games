using MathexGaming.Models.THPS;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models
{
	public class Challenge
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		public bool Completed { get; set; }

		#region Foreign key
		public int GameMapID { get; set; }
		public GameMap GameMap { get; set; } 
		#endregion
	}
}
