using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathexGaming.Models.THPS
{
	public class GameMap
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }
		
		[Required]
		[StringLength(20)]
		public string Name { get; set; }
		
		[StringLength(50)]
		public string RWLocation { get; set; }
	}
}
