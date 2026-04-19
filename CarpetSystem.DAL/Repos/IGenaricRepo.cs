using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.Repos
{
    public interface  IGenaricRepo<T> where T : class
    {

        Task<IEnumerable<T>> GetAllAsync(bool asNoTracking=true);

        Task<T> GetByIdAsync(int id);
        Task AddAsync(T Value);

        void Update(T value);
        void Delete(T Value);





    }
}
