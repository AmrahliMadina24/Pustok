using Microsoft.EntityFrameworkCore;
using Pustok.Core.Entites;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pustok.DataAccess.Contexts
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

       public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
