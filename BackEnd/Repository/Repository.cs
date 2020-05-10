using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BackEnd.Data;
using ConferenceDTO;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public virtual Task<T> GetByIdAsync<T>(int id) where T : BaseEntity
        {
            return _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);

        }

        public virtual Task<List<T>> ListAsync<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().ToListAsync();
        }

        public virtual Task<T> AddAsync<T>(T entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync<T>(T entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }



        public virtual Task<IEnumerable<T>> ListAsync<T>(Expression<Func<T, bool>> predicate) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync<T>(T entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }
    }
}
