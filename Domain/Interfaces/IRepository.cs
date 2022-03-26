﻿using Domain.Base;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> Add(TEntity entity);

        IEnumerable<TEntity> GetAll();

        Task<TEntity> Get(TId id);
    }
}