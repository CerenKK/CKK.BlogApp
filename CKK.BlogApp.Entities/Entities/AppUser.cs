using CKK.BlogApp.Entities.Abstraction;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.Entities.Entities
{
    public class AppUser : IdentityUser, IEntity
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public bool? IsBanned { get; set; } = false;
        public List<Article> Articles { get; set; }
        public AppUser()
        {
            Articles = new List<Article>();
        }
    }
       
}
