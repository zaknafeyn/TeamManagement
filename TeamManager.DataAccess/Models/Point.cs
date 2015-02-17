using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.DataAccess.Models
{
	public class Point
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Game")]
		public int GameId { get; set; }
		[ForeignKey("Team")]
		public int TeamId { get; set; }
		public int Order { get; set; }
//		[ForeignKey("Player")]
		public int? CatcherId { get; set; }
//		[ForeignKey("Player")]
		public int? AssistantId { get; set; }
		public TimeSpan AtTime { get; set; }

		public virtual Player Catcher { get; set; }
		public virtual Player Assistant { get; set; }
		public virtual Team Team { get; set; }
		public virtual Game Game { get; set; }
	}
}