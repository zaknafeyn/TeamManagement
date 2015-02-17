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
        public DbSet<Game> Games { get; set; }
        public DbSet<Point> Points { get; set; }

        public static void Configure()
        {
            Database.SetInitializer(new DbInitializer());
        }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
//			base.OnModelCreating(modelBuilder);
			GameModelDeclaration(modelBuilder);
			PointModelDeclaration(modelBuilder);
		}

		private void GameModelDeclaration(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Game>()
						.HasRequired(g => g.HomeTeam)
						.WithMany(t => t.HomeGames)
						.HasForeignKey(m => m.HomeTeamId)
						.WillCascadeOnDelete(false);

			modelBuilder.Entity<Game>()
						.HasRequired(g => g.GuestTeam)
						.WithMany(t => t.GuestGames)
						.HasForeignKey(m => m.GuestTeamId)
						.WillCascadeOnDelete(false);
		}

		private void PointModelDeclaration(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Point>()
						.HasRequired(p => p.Catcher)
						.WithMany(c => c.CoughtPoints)
						.HasForeignKey(p => p.CatcherId)
						.WillCascadeOnDelete(false);

			modelBuilder.Entity<Point>()
						.HasRequired(p => p.Assistant)
						.WithMany(c => c.AssistPoints)
						.HasForeignKey(p => p.AssistantId)
						.WillCascadeOnDelete(false);
		}
    }
}