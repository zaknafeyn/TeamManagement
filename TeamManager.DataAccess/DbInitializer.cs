using System.Collections.Generic;
using System.Data.Entity;
using TeamManager.DataAccess.Models;

namespace TeamManager.DataAccess
{
    public class DbInitializer : DropCreateDatabaseAlways<TeamManagerContext>
    {
        protected override void Seed(TeamManagerContext context)
        {
            var ukraine = new Country
            {
                ID = 0,
                Name = "Ukraine"
            };
            context.Countries.Add(ukraine);

            var kyiv = new City
            {
                ID = 0,
                Name = "Kyiv",
                Country = ukraine.ID
            };
            context.Cities.Add(kyiv);

            var teamId = 0;
            var teams = new List<Team>
            {
                new Team
                {
                    ID = teamId,
                    City = kyiv.ID,
                    TeamName = string.Format("Team {0}", teamId),
                    WebSite = string.Format("Team{0}WebSite", teamId++)
                },
                new Team
                {
                    ID = teamId,
                    City = kyiv.ID,
                    TeamName = string.Format("Team {0}", teamId),
                    WebSite = string.Format("Team{0}WebSite", teamId++)
                },
                new Team
                {
                    ID = teamId,
                    City = kyiv.ID,
                    TeamName = string.Format("Team {0}", teamId),
                    WebSite = string.Format("Team{0}WebSite", teamId++)
                }
            };

            var playerId = 0;
            foreach (var team in teams)
            {
                context.Teams.Add(team);

                for (int i = 0; i < 5; i++)
                {
                    context.Players.Add(new Player
                    {
                        ID = playerId,
                        FirstName = string.Format("FirstName{0}", playerId),
                        LastName = string.Format("LastName{0}", playerId),
                        TeamId = team.ID,
                        IsCapitan = false
                    });

                    playerId++;
                }
                
                // add capitan
                context.Players.Add(new Player
                {
                    ID = playerId,
                    FirstName = string.Format("CapFirstName{0}", playerId),
                    LastName = string.Format("CapLastName{0}", playerId),
                    TeamId = team.ID,
                    IsCapitan = true
                });

                playerId++;
            }


            context.SaveChanges();
            base.Seed(context);
        }
    }
}