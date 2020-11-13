using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfCore3
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Entity> Entities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>()
                .Property(_ => _.Times)
                .HasConversion(dt => string.Join(";", dt),
                    s => s.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(DateTime.Parse).ToArray());
        }
    }
}
