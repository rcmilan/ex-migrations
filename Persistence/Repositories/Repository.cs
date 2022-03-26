using Domain.Base;
using Domain.Interfaces;
using Persistence.Configurations;

namespace Persistence.Repositories
{
    internal class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        private readonly PersistenceDbContext _context;

        public Repository(PersistenceDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _context.Set<TEntity>()
                .AddAsync(entity);

            _context.SaveChanges();

            return entity;
        }

        public async Task<TEntity> Get(TId id)
        {
            var entity = await _context.Set<TEntity>()
                .FindAsync(id);

            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            var entities = _context.Set<TEntity>()
                .ToList();

            return entities;
        }
    }
}
