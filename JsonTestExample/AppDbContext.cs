using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTestExample
{
    public class AppDbContext:DbContext
    {
        public DbSet<Question> Questions { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(entity =>
            {
                entity.OwnsMany(q => q.Options, options =>
                {
                    options.ToJson();
                });
            }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EP0C18I; Database=TestJsonExample;" +
                " Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
}
