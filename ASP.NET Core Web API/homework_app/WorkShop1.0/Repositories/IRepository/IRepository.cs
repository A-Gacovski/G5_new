using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Enums;

namespace WorkShop1._0.Repositories.IRepository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
