using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004TaskAllWebApi.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> All();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity FindById(int Id);
        TEntity FindById(string Id);
    }
}
