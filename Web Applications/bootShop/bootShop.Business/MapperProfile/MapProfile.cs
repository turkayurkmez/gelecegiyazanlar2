using AutoMapper;
using bootShop.Dtos.Requests;
using bootShop.Dtos.Responses;
using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business.MapperProfile
{
   public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductListResponse>();
            CreateMap<AddProductRequest, Product>();
            CreateMap<UpdateProductRequest, Product>();
        }
    }
}
