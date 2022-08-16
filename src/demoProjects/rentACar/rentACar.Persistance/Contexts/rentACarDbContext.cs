using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Persistance.Contexts
{
    public class rentACarDbContext : DbContext
    {

        protected IConfiguration Configuration { get; set; }
        public DbSet<Brand> Brands { get; set; }


        public rentACarDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(x =>
            {
                x.ToTable("Brands").HasKey(k => k.Id);
                x.Property(p => p.Id).HasColumnName("Id");
                x.Property(p => p.Name).HasColumnName("Name");
            });

            Brand[] brandEntitySeeds = { new Brand { Id = 1, Name = "BMW" }, new Brand { Id = 2, Name = "Mercedes" } };

            modelBuilder.Entity<Brand>().HasData(brandEntitySeeds);
        }

    }
}
