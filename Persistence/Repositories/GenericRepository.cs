using Domain.Base;
using Domain.Interfaces;
using Persistence.Configurations;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    internal class GenericRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        private readonly PersistenceDbContext _context;

        public GenericRepository(PersistenceDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _context.Set<TEntity>()
                .AddAsync(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(TId id)
        {
            var entity = await _context.Set<TEntity>()
                .FindAsync(id);

            return entity;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = _context.Set<TEntity>().Where(predicate).ToList();

            return entities;
        }

        public IEnumerable<TEntity> GetAll()
        {
            var entities = _context.Set<TEntity>()
                .ToList();

            return entities;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}