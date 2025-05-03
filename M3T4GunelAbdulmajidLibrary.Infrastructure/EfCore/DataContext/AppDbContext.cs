using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Infrastructure.EfCore.DataContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<UserBook> UserBooks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EP0C18I; Database=M3T4Library; Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
}
