using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class FakeProductService : IProductService
    {
        private List<Product> products;
        public FakeProductService()
        {
            products = new List<Product>
             {
                 new Product{ Id=1, Name="Dell XPS 13 ", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=1, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                 new Product{ Id=2, Name="Samsung", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=1, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                 new Product{ Id=3, Name="MacBook Air ", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=1, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                  new Product{ Id=4, Name="A", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=2, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                 new Product{ Id=5, Name="B", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=1, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                 new Product{ Id=6, Name="C", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=2, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                   new Product{ Id=5, Name="X", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=1, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
                 new Product{ Id=6, Name="Y", Price=10000, Discount=0.15, Descriptipn="8 GB ram", CategoryId=3, ImageUrl="https://productimages.hepsiburada.net/s/137/222-222/110000089760432.jpg"},
             };
        }

        public Task<int> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetProducts()
        {
            return products;
        }

        Task<ICollection<Product>> IProductService.GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
