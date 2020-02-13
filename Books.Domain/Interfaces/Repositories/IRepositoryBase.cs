using System;
using System.Linq;
using System.Linq.Expressions;

namespace Books.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);

        IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        void Delete(TEntity entity);
    }
}
