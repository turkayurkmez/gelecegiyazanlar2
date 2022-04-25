using bootShop.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootShop.API.Filters
{
    //public class IsExistAttribute : ActionFilterAttribute
    //{
    //    public override void OnActionExecuting(ActionExecutingContext context)
    //    {
    //        var idExist = context.ActionArguments.ContainsKey("id");
    //        if (!idExist)
    //        {
    //            context.Result = new BadRequestObjectResult(new { message = $"id parametresi yok!" });
    //            return;
    //        }

    //        var id = (int)context.ActionArguments["id"];


    //    }
    //}

    public class CheckExisting : IAsyncActionFilter
    {
        private readonly IProductService productService;

        public CheckExisting(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var idExist = context.ActionArguments.ContainsKey("id");
            if (!idExist)
            {
                context.Result = new BadRequestObjectResult(new { message = $"id parametresi yok!" });

            }
            else
            {
                var id = (int)context.ActionArguments["id"];
                if (await productService.IsExist(id))
                {
                   await next.Invoke();
                }

                context.Result = new BadRequestObjectResult(new { message = $"{id} id'li ürün bulunamadı" });
            }

           


        }
    }
}
