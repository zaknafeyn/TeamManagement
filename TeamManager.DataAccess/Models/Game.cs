using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.DataAccess.Models
{
	public class Game
	{
		[Key]
		public int Id { get; set; }
		public int GuestTeamId { get; set; }
		public int HomeTeamId { get; set; }

		public virtual ICollection<Point> Points { get; set; }
		public virtual Team HomeTeam { get; set; }
		public virtual Team GuestTeam { get; set; }
	}
}