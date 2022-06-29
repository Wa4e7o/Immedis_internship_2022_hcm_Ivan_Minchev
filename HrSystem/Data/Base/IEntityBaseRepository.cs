﻿namespace HrSystem.Models.Base
{
    using System;
    using HrSystem.Data.Base;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    // We can make models generic, <T> is class
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T newEntity);

        Task DeleteAsync(int id);
    }
}