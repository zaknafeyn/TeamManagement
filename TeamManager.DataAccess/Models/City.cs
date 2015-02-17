using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.DataAccess.Models
{
    public class City
    {
		[Key]
        public int ID { get; set; } 
        public string Name { get; set; }
        public int Country { get; set; }
    }
}