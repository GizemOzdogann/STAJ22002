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
            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animals");
                entity.HasKey(e => e.Id); // Primary key configuration
                entity.Property(e => e.Gender).IsRequired(false); // Nullable or required
                entity.Property(e => e.Age).IsRequired();
                entity.Property(e => e.LifeTick).IsRequired();
                entity.Property(e => e.ProductTick).IsRequired();
            });
        }
    }
}
