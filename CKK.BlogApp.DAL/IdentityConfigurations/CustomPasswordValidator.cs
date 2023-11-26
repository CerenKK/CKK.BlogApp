using CKK.BlogApp.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.IdentityConfigurations
{
    public class CustomPasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            var errors = new List<IdentityError>();
            if (password!.ToLower().Contains(user.UserName)) 
            {
                errors.Add(new() { Code = "1", Description = "Şifre kullanıcı adı içeremez." });
            }
            if (password!.ToLower().Contains("123456"))
            {
                errors.Add(new() { Code = "2", Description = "Şifre çok basit" });
            }
            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
