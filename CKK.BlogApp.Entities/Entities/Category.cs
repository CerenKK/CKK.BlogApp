using CKK.BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.Entities.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Articles = new List<Article>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public List<Article> Articles { get; set; }
    }
}
