using CKK.BlogApp.DAL.Repository;
using CKK.BlogApp.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.Uow.Abstract
{
    public interface IUow
    {
        void SaveChanges();
        public IRepository<T> GetRepository<T>() where T : class, IEntity;
    }
}
