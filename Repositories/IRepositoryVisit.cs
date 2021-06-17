using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scoliosis.Repositories
{
    public interface IRepositoryVisit<TEntity, TKey>
          where TEntity : class
    {
        TKey Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TKey id, TKey id2);

        TEntity FindById(TKey id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

    }
}
