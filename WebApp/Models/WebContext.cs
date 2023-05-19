using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public partial class WebContext : DbContext
    {
        public WebContext()
        {

        }

        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {

        }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=LAPTOP-A8RA8SB1;Database=PruebaWeb;Integrated Security=true;TrustServerCertificate=True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(300);
                entity.Property(e => e.ImageUrl).HasMaxLength(300);
                
            });

            base.OnModelCreating(modelBuilder);
        }

        partial void onModelCreatPartial(ModelBuilder modelBuilder);
    }
}