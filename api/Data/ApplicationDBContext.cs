using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasMany(e => e.Orders)
            .WithMany(e => e.Products)
            .UsingEntity<Order_Detail>();

            modelBuilder.Entity<Product>()
            .HasMany(e => e.Colors)
            .WithMany(e => e.Products)
            .UsingEntity<Product_color>();

            modelBuilder.Entity<Product>()
            .HasMany(e => e.Sizes)
            .WithMany(e => e.Products)
            .UsingEntity<Product_size>();

            modelBuilder.Entity<Product>()
            .HasMany(e => e.Materials)
            .WithMany(e => e.Products)
            .UsingEntity<Product_material>();

            modelBuilder.Entity<Product>()
            .HasMany(e => e.Images)
            .WithMany(e => e.Products)
            .UsingEntity<Product_image>();

            modelBuilder.Entity<Department>()
            .HasMany(e => e.Employees)
            .WithOne(e => e.Department);

            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department);
            
        }

        public DbSet<Category> Categories {get; set;}
        public DbSet<Color> Colors {get; set;}
        public DbSet<Company> Companies {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Department> Departments {get; set;}
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Image> Images {get; set;}
        public DbSet<Material> Materials {get; set;}
        public DbSet<Order_Detail> Order_Details {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Product_color> Product_Colors {get; set;}
        public DbSet<Product_image> Product_Images {get; set;}
        public DbSet<Product_material> Product_Materials {get; set;}
        public DbSet<Product_size> Product_Sizes {get; set;}
        public DbSet<Product> Products {get; set;}

    }
}