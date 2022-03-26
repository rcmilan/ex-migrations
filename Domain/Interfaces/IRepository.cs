using Domain.Base;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> Get(TId id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll();

        Task<TEntity> Update(TEntity entity);
    }
}