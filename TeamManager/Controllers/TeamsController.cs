using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Helpers;
using System.Web.Http;
using Antlr.Runtime;
using Newtonsoft.Json;
using TeamManager.DataAccess;
using TeamManager.DataAccess.Models;

namespace TeamManager.Controllers
{
    public class TeamsController : ApiController
    {
        TeamManagerContext context = new TeamManagerContext();
        // GET api/team
        public string Get()
        {
            var teams = context.Teams.Select(x => new {x.ID, x.TeamName, x.WebSite }).ToArray();
            if (teams.Length > 0)
            {
                return JsonConvert.SerializeObject(teams);
            }

            return null;
        }

        // GET api/team/5
        public string Get(int id)
        {
            var team = context.Teams.SingleOrDefault(x => x.ID == id);

            if (team == null)
                return null;

            return team.TeamName;
        }

        // POST api/team
        public void Post([FromBody]string value)
        {
        }

        // PUT api/team/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/team/5
        public void Delete(int id)
        {
        }
    }
}
