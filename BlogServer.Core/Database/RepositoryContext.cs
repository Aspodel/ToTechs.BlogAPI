using BlogServer.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogServer.Core.Database
{
    public class RepositoryContext : IdentityDbContext<Account, IdentityRole<int>, int>
    {

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        public DbSet<Author> Author { get; set; }

        public DbSet<Blog> Blog { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BlogAuthor>(entity =>
            {
                entity.HasOne(ba => ba.Author).WithMany(a => a!.BlogAuthors).HasForeignKey(ba => ba.AuthorId).IsRequired().OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(ba => ba.Blog).WithMany(b => b!.BlogAuthors).HasForeignKey(ba => ba.BlogId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
