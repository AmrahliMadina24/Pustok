using Microsoft.EntityFrameworkCore;
using Pustok.Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pustok.DataAccess.Contexts
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
