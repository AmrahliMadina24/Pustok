using Pustok.Core.Entites.Common;
using Pustok.DataAccess.Contexts;
using Pustok.DataAccess.Repositories.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pustok.DataAccess.Repositories.Implementations.Generic
{
    internal class Repository<T>(AppDbContext _context): IRepository<T> where T : BaseEntity
    {

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
           
        }

        public void Delete(T entity)
        {
           _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
           
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
           var entity = await _context.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync();    
        }

        public void Update(T entity)
        {
           _context.Set<T>().Update(entity);
        }
    }
}
