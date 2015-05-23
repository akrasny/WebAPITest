using DataLayer.Entities;
using DataLayer.EntityFramework;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Implementation
{
    public class MySvcRepository : IMySvcRepository
    {
        DataContext _db;

        public MySvcRepository(string connectionString)
        {
            _db = new DataContext(connectionString);
        }

        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }

        public User GetUser(int id)
        {
            return _db.Users.Where(o => o.Id == id).FirstOrDefault();
        }
    }
}
