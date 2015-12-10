using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotChat.API.Controllers.V1
{
    [RoutePrefix("api/v2/user")]
    public class UserController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        // Must add "Route" attribute if we want "RoutePrefix" workable.
        [Route("getuser/{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            int i = 3;
            i++;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
            int i = 9;
            i++;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}