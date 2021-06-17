﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scoliosis.Repositories
{
    public interface IRepositoryPOImport<TEntity, TKey>
        where TEntity : class
    {
        TKey Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TKey id);

        List<TEntity> FindById(TKey id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

        //IQueryable<TEntity> GetAll();


    }
}
