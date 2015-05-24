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
    public class OrderController : ApiController
    {
        private IMySvcRepository _repo;

        public OrderController(IMySvcRepository r)
        {
            _repo = r;
        }

        // GET: api/Order
        public List<Order> Get(int userid)
        {
            return _repo.GetOrders(userid);
        }

        // GET: api/Order/5
        public Order Get(int userid, int id)
        {
            return _repo.GetOrder(userid, id);
        }

        // POST: api/Order
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
