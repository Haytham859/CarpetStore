using CarpetSystem.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.Unit
{
    public class UnitOfWork:IUnitOfWork
    {

        private readonly ApplicationDbContext _context;

        public IGenaricRepo<Product> Products { get; }

        public IGenaricRepo<Category> Categories { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Products = new GenaricRepo<Product>(_context);
            Categories=new GenaricRepo<Category>(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
