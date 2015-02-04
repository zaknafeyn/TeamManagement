using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamManager.DataAccess.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; } 
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}