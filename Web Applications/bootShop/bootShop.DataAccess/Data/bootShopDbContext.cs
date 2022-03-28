using bootShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Data
{
    public class bootShopDbContext : DbContext
    {

        public bootShopDbContext(DbContextOptions<bootShopDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Category>().HasData(
                   new Category
                   {
                       Id = 1,
                       Name = "Telefon"
                     
                   },
                   new Category
                   {
                       Id = 2,
                       Name = "Laptop",                     
                   },
                   new Category {  Id=3, Name="Tablet"}                  

                );


            modelBuilder.Entity<Product>().HasData(

                           new Product { Id = 1, Name = "IPhone", Price = 1500, Discount = 0.15, ImageUrl = "https://productimages.hepsiburada.net/s/65/200-200/110000007077895.jpg", CategoryId = 1 },

                           new Product { Id = 2, Name = "Oppo", Price = 1500, Discount = 0.15, ImageUrl = "https://productimages.hepsiburada.net/s/65/200-200/110000007077895.jpg", CategoryId = 1 },

                           new Product { Id = 3, Name = "Xiaomi", Price = 1500, Discount = 0.15, ImageUrl = "https://productimages.hepsiburada.net/s/65/200-200/110000007077895.jpg", CategoryId = 1 },

                            new Product { Id = 4, Name = "Macbook pro", Price = 1500, Discount = 0.15, ImageUrl = "https://productimages.hepsiburada.net/s/195/200-200/110000163717661.jpg", CategoryId = 2 },

                           new Product { Id = 5, Name = "Dell XPS 13", Price = 1500, Discount = 0.15, ImageUrl = "https://productimages.hepsiburada.net/s/195/200-200/110000163717661.jpg", CategoryId = 2 },

                           new Product
                           {
                               Id = 6,
                               Name = "Huawei",
                               Price = 1500,
                               Discount = 0.15,
                               ImageUrl = "https://productimages.hepsiburada.net/s/195/200-200/110000163717661.jpg",
                               CategoryId = 2
                           }
                           );



        }

      
    }
}
