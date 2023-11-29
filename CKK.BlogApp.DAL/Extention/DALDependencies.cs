using CKK.BlogApp.DAL.Context;
using CKK.BlogApp.DAL.IdentityConfigurations;
using CKK.BlogApp.DAL.Uow.Abstract;
using CKK.BlogApp.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CKK.BlogApp.DAL.Uow.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.Extention
{
    public static class DALDependencies
    {
        public static void AddDALDependencies( this IServiceCollection services, string conString)
        {
            services.AddDbContext<AppDbContext>(x => 
            {
                x.UseSqlServer(conString);  
                
            });

            services.AddIdentity<AppUser, AppRole>(options => 
            {
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false; //İleride true olacak
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);
                options.Lockout.MaxFailedAccessAttempts = 3;

                options.Password.RequireNonAlphanumeric = false; //İleride true olacak
                options.Password.RequireLowercase = false; 
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
            
            }).AddPasswordValidator<CustomPasswordValidator>()
            .AddUserValidator<CustomUserValidator>()
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<AppDbContext>();


            services.Configure<SecurityStampValidatorOptions>(option =>
            {
                option.ValidationInterval = TimeSpan.FromMinutes(100);
            });



            services.Configure<DataProtectionTokenProviderOptions>(option =>
            {
                option.TokenLifespan = TimeSpan.FromHours(5);
            });



            
            services.Configure<SecurityStampValidatorOptions>(option =>
            {
                option.ValidationInterval = TimeSpan.FromMinutes(100);
            });



            services.Configure<DataProtectionTokenProviderOptions>(option =>
            {
                option.TokenLifespan = TimeSpan.FromHours(5);
            });

        

        }


    }
}
