using BlogsData.Entities;
using BlogsData.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogsData.Context
{
    public class Context : DbContext
    {
        public DbSet<BlogEntity> Blogs { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogEntity>().ToTable("Blog");
            modelBuilder.Entity<CategoryEntity>().ToTable("Category");
            modelBuilder.Entity<BlogEntity>().HasMany(s => s.Categories).WithMany(c => c.Blogs);
        }
    }
}