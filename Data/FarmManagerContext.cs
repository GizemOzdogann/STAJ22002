using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FarmManager.Entities;

namespace FarmManager.Data
{
    public class FarmManagerContext : DbContext
    {
        public FarmManagerContext(DbContextOptions<FarmManagerContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Animal>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

        }
    }
}
