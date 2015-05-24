using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IMySvcRepository
    {
        /// <summary>
        /// Get Users
        /// </summary>
        /// <returns></returns>
        List<User> GetUsers();

        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUser(int id);

        /// <summary>
        /// Get Orders
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        List<Order> GetOrders(int userid);

        Order GetOrder(int userid, int id);
    }
}
