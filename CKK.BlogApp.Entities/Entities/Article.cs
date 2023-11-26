using CKK.BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.Entities.Entities
{
    public class Article : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int ViewCount { get; set; } = 0;
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Image Image { get; set; }
        public int ImageId { get; set; }
    }
}
