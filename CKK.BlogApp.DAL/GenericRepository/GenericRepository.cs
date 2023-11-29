using CKK.BlogApp.DAL.Context;
using CKK.BlogApp.DAL.Repository;
using CKK.BlogApp.Entities.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.GenericRepository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(T entity)
        {
            _appDbContext.Set<T>().Add(entity);

        }

        public void Delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
        }

        public void GetAll()
        {
            _appDbContext.Set<T>().ToList();
           
        }

        public void GetById(int id)
        {
            _appDbContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetQueryable()
        {
            return _appDbContext.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            _appDbContext.Update(entity);
        }
    }
}
