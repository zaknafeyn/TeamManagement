using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamManager.DataAccess.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsCapitan { get; set; }

		public virtual ICollection<Point> CoughtPoints { get; set; }
		public virtual ICollection<Point> AssistPoints { get; set; }
    }
}