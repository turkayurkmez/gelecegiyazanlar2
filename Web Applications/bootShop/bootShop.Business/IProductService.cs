using bootShop.Dtos.Requests;
using bootShop.Dtos.Responses;
using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
   public  interface IProductService
    {
        Task<ICollection<ProductListResponse>> GetProducts();
        Task<int> AddProduct(AddProductRequest product);
        Task<bool> IsExist(int id);
        Task<ProductListResponse> GetProductById(int id);
        Task<int> UpdateProduct(UpdateProductRequest request);
        Task DeleteProduct(int id);
    }
}
