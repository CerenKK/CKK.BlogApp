using CKK.BlogApp.DAL.Context;
using CKK.BlogApp.DAL.GenericRepository;
using CKK.BlogApp.DAL.Repository;
using CKK.BlogApp.DAL.Uow.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.Uow.Concrete
{
    public class Uow : IUow
    {
        private readonly AppDbContext _dbContext;

        public Uow(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        IRepository<T> IUow.GetRepository<T>()
        {
            return new GenericRepository<T>(_dbContext);
        }
    }
}
