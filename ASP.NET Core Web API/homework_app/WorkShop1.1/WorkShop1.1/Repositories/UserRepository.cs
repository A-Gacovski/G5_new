using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Enums;
using WorkShop1._0.Repositories.IRepository;

namespace WorkShop1._0.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {
            CashDb.UserIdCounter++;
            entity.Id = CashDb.UserIdCounter;
            CashDb.Users.Add(entity);
        }

        public void Delete(User entity)
        {
            var deleteUser = CashDb.Users.FirstOrDefault(u => u.Id == entity.Id);
            if (deleteUser != null)
            {
                CashDb.Users.Remove(deleteUser);
            }
        }

        public List<User> GetAll()
        {
            return CashDb.Users;
        }

        public void Update(User entity)
        {
            var updateUser = CashDb.Users.FirstOrDefault(u => u.Id == entity.Id);
            if (updateUser != null)
            {
                var indexOfUser = CashDb.Users.IndexOf(updateUser);
                CashDb.Users[indexOfUser] = entity;
            }
        }
    }
}
