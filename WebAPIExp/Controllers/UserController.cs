using DataLayer.Entities;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIExp.Controllers
{
    public class UserController : ApiController
    {
        private IMySvcRepository _repo;

        public UserController(IMySvcRepository r)
        {
            _repo = r;
        }

        // GET: api/Some
        public IEnumerable<User> Get()
        {
            return _repo.GetUsers();
        }

        // GET: api/Some/5
        public User Get(int userid)
        {
            return _repo.GetUser(userid);
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
