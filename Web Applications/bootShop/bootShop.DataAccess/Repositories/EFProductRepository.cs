using bootShop.DataAccess.Data;
using bootShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private bootShopDbContext context;

        public EFProductRepository(bootShopDbContext context)
        {
            this.context = context;
        }
        public async Task<int> Add(Product entity)
        {
            entity.CreatedDate = DateTime.Now;
            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id;
        }

        public async  Task Delete(int id)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
            context.Products.Remove(product);
            await context.SaveChangesAsync();

        }

        public async Task<IList<Product>> GetAllEntities()
        {
            return await context.Products.ToListAsync();

        }

        public async Task<Product> GetEntityById(int id)
        {
            
            return await context.Products.FindAsync(id);
        }

        public async Task<bool> IsExists(int id)
        {
            return await context.Products.AnyAsync(p => p.Id == id);
        }

        public async Task<IList<Product>> SearchProductsByName(string name)
        {
            return await context.Products.Where(p => p.Name.Contains(name)).ToListAsync();
        }

        public async Task<int> Update(Product entity)
        {
            entity.ModifiedDate = DateTime.Now;
            context.Products.Update(entity);
           return  await context.SaveChangesAsync();
           
        }
    }
}
