using CKK.BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.Entities.Entities
{
    public class Image : BaseEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public List<Article> Articles { get; set; }

    }
}
