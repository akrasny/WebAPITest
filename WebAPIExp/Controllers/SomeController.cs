using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIExp.Controllers
{
    public class SomeController : ApiController
    {
        public SomeController(IMySvcRepository r)
        {

        }

        // GET: api/Some
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Some/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Some
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Some/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Some/5
        public void Delete(int id)
        {
        }
    }
}
