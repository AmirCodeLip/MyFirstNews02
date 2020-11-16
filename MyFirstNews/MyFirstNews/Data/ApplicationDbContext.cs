using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstNews.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstNews.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {



        }
        public DbSet<News> Newses { get; set; }
        public DbSet<NewsAndTag> NewsAndTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<NewsAndTag>().HasKey("TagId", "NewsId");

            builder.Entity<Tag>().HasOne(x => x.Parent).WithMany(x => x.Childs).
                HasForeignKey(k => k.ParentId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

        }
    }
}

