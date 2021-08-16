using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models.Entites;
using Storage.Models.ViewModels;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = 1,
                         Name = "Iphone 12",
                         Category = "Mobile",
                         Count = 156,
                         Description = "Beskrivning av telefonen här",
                         OrderDate = DateTime.Now.AddDays(-6),
                         Price = 15600,
                         Shelf = "4B"
                     }, new Product
                     {
                         Id = 2,
                         Name = "S20",
                         Category = "Mobile",
                         Count = 98,
                         Description = "Beskrivning av telefonen här",
                         OrderDate = DateTime.Now.AddDays(-23),
                         Price = 12450,
                         Shelf = "4C"
                     }, new Product
                     {
                         Id = 3,
                         Name = "MacBook",
                         Category = "Computers",
                         Count = 23,
                         Description = "Beskrivning här",
                         OrderDate = DateTime.Now.AddDays(-5),
                         Price = 45600,
                         Shelf = "4C"
                     }, new Product
                     {
                         Id = 4,
                         Name = "Suface X",
                         Category = "Computer",
                         Count = 32,
                         Description = "Beskrivning här",
                         OrderDate = DateTime.Now.AddDays(-40),
                         Price = 26850,
                         Shelf = "5C"
                     }, new Product
                     {
                         Id = 5,
                         Name = "Pen",
                         Category = "Office Supplies",
                         Count = 15651,
                         Description = "Beskrivning här",
                         OrderDate = DateTime.Now.AddDays(-6),
                         Price = 1,
                         Shelf = "45W"
                     }
                );

        }

    }
}
