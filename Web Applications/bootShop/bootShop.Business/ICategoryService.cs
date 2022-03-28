using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
   public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
