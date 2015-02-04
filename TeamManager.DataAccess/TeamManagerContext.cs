using System.Data.Entity;
using TeamManager.DataAccess.Models;

namespace TeamManager.DataAccess
{
    [DbConfigurationType(typeof(TeamManagerDbConfiguration))] 
    public class TeamManagerContext : DbContext
    {
        public TeamManagerContext()
            : base("TeamManagerContext")
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public static void Configure()
        {
            Database.SetInitializer(new DbInitializer());
        }
    }
}