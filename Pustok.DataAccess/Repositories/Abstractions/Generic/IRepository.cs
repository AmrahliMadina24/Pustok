using Pustok.Core.Entites.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pustok.DataAccess.Repositories.Abstractions.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        Task<T?> GetByIdAsync(Guid id);

        Task<int> SaveChangesAsync();
    }
}
