using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IBaseRepository<T> where T : class, IBaseEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        List<T> GetAll();
    }
}
