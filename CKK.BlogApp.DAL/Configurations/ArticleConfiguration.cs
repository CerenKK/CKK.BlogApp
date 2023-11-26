using CKK.BlogApp.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.BlogApp.DAL.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(50).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x=>x.Articles).HasForeignKey(x=>x.CategoryId);
            builder.HasOne(x => x.Image).WithMany(x => x.Articles).HasForeignKey(x => x.ImageId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Articles).HasForeignKey(x => x.AppUserId);
        }
    }
}
