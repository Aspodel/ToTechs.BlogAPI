using BlogServer.Contracts;
using BlogServer.Core.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogServer.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext RepositoryContext;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
            _dbSet = RepositoryContext.Set<T>();
        }

        public virtual IQueryable<T> FindAll()
        {
            return _dbSet.AsNoTracking();
        }

        public virtual async Task<T> FindByIdAsync(int id)
        {
            var item = await RepositoryContext.FindAsync<T>(id);
            return item;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public Task SaveChangesAsync()
            => RepositoryContext.SaveChangesAsync();
    }
}
