﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeamManager.Controllers
{
    public class PlayersController : ApiController
    {
        // GET api/players
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/players/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/players
        public void Post([FromBody]string value)
        {
        }

        // PUT api/players/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/players/5
        public void Delete(int id)
        {
        }
    }
}
