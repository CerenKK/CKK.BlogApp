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
        void Add (T entity);
        void Update (T entity);
        void Delete (T entity);
        void GetAll();
        void GetById (int id);
        IQueryable<T> GetQueryable();
    }
}
