using System.Data.Entity;
using TeamManager.DataAccess.Models;

namespace TeamManager.DataAccess
{
    public class DbInitializer : DropCreateDatabaseAlways<TeamManagerContext>
    {
        protected override void Seed(TeamManagerContext context)
        {
            var country = new Country
            {
                ID = 0,
                Name = "Ukraine"
            };
            context.Countries.Add(country);
            context.SaveChanges();

            var city = new City
            {
                ID = 0,
                Name = "Kyiv",
                Country = country.ID
            };
            context.Cities.Add(city);
            context.SaveChanges();

            var team = new Team
            {
                ID = 0,
                City = city.ID, 
                TeamName = "Nova",
                WebSite = "nova-ultimate.com"
            };
            context.Teams.Add(team);
            context.SaveChanges();

            var player = new Player
            {
                ID = 0,
                FirstName = "First",
                LastName = "Capitan",
                TeamId = team.ID,
                IsCapitan = true
            };
            context.Players.Add(player);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}