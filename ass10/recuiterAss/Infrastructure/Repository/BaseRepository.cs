using AppCore.Contracts.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly RecruitingDbContext _db;
        public BaseRepository(RecruitingDbContext context) 
        {
            _db = context;
        }
        public async Task<int> DeleteAsync(int id)
        {
            var target = await _db.Set<T>().FindAsync(id);
            _db.Set<T>().Remove(target);
            await _db.SaveChangesAsync();
            return 1;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _db.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<int> InsertAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return 1;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return 1;
        }
    }
}
