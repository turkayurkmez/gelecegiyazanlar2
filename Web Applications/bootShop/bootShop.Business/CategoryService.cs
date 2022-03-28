using bootShop.DataAccess.Data;
using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class CategoryService : ICategoryService
    {
        private bootShopDbContext dbContext;

        public CategoryService(bootShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IList<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }
    }
}
