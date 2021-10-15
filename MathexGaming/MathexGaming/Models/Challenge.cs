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
		
		[ForeignKey("GameMap")]
		public int GameMapId { get; set; }
		//public Challenge(int id, string name)
		//{
		//	Id = id;
		//	Name = name;
		//}
	}
}
