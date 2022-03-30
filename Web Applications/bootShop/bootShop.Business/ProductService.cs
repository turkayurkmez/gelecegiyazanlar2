using bootShop.DataAccess.Data;
using bootShop.DataAccess.Repositories;
using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<int> AddProduct(Product product)
        {
            return await productRepository.Add(product);
        }

        public async Task<ICollection<Product>> GetProducts()
        {
            return await productRepository.GetAllEntities();
        }
    }
}
