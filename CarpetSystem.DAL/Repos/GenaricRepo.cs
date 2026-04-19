using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.Repos
{
    public class GenaricRepo<T> : IGenaricRepo<T> where T : class
    {


        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenaricRepo(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public async Task AddAsync(T Value)
        {

            await _dbSet.AddAsync(Value);
        }

        public void Delete(T Value)
        {
            _dbSet.Remove(Value);
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool asNoTracking=true)
        {
            if(asNoTracking)
                return await _dbSet.AsNoTracking().ToListAsync();

            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(T value)
        {
            _dbSet.Update(value);
        }
    }
}
