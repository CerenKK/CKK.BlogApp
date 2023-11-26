using CKK.BlogApp.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.Repository
{
    public interface IRepository <T> where T : class, IEntity
    {
        Task AddAsync (T entity);
        Task UpdateAsync (T entity);
        Task DeleteAsync (T entity);
        Task<T> GetAllAsync();
        Task<T> GetByIdAsync (int id);
        IQueryable<T> GetQueryable();
    }
}
