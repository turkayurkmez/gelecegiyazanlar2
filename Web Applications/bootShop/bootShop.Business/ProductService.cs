using AutoMapper;
using bootShop.DataAccess.Data;
using bootShop.DataAccess.Repositories;
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
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<int> AddProduct(AddProductRequest request)
        {
            //var product = new Product
            //{
            //    CategoryId = request.CategoryId,
            //    CreatedDate = DateTime.Now,
            //    Descriptipn = request.Descriptipn,
            //    Discount = request.Discount,
            //    ImageUrl = request.ImageUrl,
            //    Name = request.Name,
            //    Price = request.Price
            //};

            var product = mapper.Map<Product>(request);
            return await productRepository.Add(product);
        }

        public async Task DeleteProduct(int id)
        {
            await productRepository.Delete(id);
        }

        public async Task<ProductListResponse> GetProductById(int id)
        {
            Product product = await productRepository.GetEntityById(id);
            var response = mapper.Map<ProductListResponse>(product);
            return response;
        }

        public async Task<ICollection<ProductListResponse>> GetProducts()
        {
            var products = await productRepository.GetAllEntities();
            // var productListResponses = new List<ProductListResponse>();

            //products.ToList().ForEach(p => productListResponses.Add(new ProductListResponse
            //{
            //     CategoryId = p.CategoryId,
            //     Descriptipn = p.Descriptipn,
            //     Discount = p.Discount,
            //     ImageUrl=p.ImageUrl,
            //     Id = p.Id,
            //     Name=p.Name,
            //     Price = p.Price
            //}));

            var productListResponses = mapper.Map<List<ProductListResponse>>(products);
            return productListResponses;
        }

        public async  Task<bool> IsExist(int id)
        {
            return await productRepository.IsExists(id);
        }

        public async Task<int> UpdateProduct(UpdateProductRequest request)
        {
            var product = mapper.Map<Product>(request);
            var result = await productRepository.Update(product);
            return result;

        }
    }
}
