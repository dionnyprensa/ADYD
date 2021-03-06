﻿using ADYD.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ADYD.Infrastructure
{
    public class ApplicationUserStore : UserStore<User>
    {
        public ApplicationUserStore(ApplicationDbContext context) : base(context)
        {
        }
    }

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        //public DbSet<Access> Access { get; set; }
        //public DbSet<Customer> Clients { get; set; }
        //public DbSet<DetailSale> DetailSales { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Sale> Sales { get; set; }

        public ApplicationDbContext() : base("ADyD")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<IdentityUserLogin>().HasKey(l => l.UserId);
            //modelBuilder.Entity<IdentityRole>().HasKey(r => r.Id);
            //modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            //modelBuilder.Entity<User>().HasKey(r => r.Id);

            //modelBuilder.Configurations.Add(new ProductConfig());
            //modelBuilder.Configurations.Add(new ClientConfig());
            //modelBuilder.Configurations.Add(new AccessConfig());
            //modelBuilder.Configurations.Add(new RoleConfig());
            //modelBuilder.Configurations.Add(new UserConfig());
            //modelBuilder.Configurations.Add(new SaleConfig());
            //modelBuilder.Configurations.Add(new DetailSaleConfig());

            //modelBuilder.Entity<Sale>()
            //    .HasRequired(c => c.Client)
            //    .WithMany(s => s.Purchases);

            //modelBuilder.Entity<Sale>()
            //    .HasRequired(c => c.User)
            //    .WithMany(s => s.Sales);

            //base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}