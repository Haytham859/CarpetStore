using CarpetSystem.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.Unit
{
    public interface IUnitOfWork:IDisposable
    {
        IGenaricRepo<Product> Products { get; }
        IGenaricRepo<Category>Categories { get; }
        Task<int> SaveAsync();


    }
}
