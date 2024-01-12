using Microsoft.EntityFrameworkCore;
using PostsUser.Models;

namespace PostsUser.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        { }

        public DbSet<PostModel> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<PostModel>().HasKey(x => x.Id);
            modelBuilder.Entity<PostModel>().Property(x => x.Content).HasMaxLength(500).IsRequired();
        }
    }
}
