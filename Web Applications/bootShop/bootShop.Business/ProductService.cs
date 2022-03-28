using bootShop.DataAccess.Data;
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
        private bootShopDbContext dbContext;

        public ProductService(bootShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ICollection<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }
    }
}
