using bootShop.Business;
using bootShop.Dtos.Requests;
using bootShop.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootShop.Web.Controllers
{

    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await productService.GetProducts();
            return View(products);

        }
        [HttpGet]
        public IActionResult Create()
        {
            var selectedItems = new List<SelectListItem>();
            categoryService.GetCategories()
                           .ToList()
                           .ForEach(category => selectedItems.Add(
                               new SelectListItem
                               {
                                   Text = category.Name,
                                   Value = category.Id.ToString()
                               })
            );

            ViewBag.Categories = selectedItems;


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name","Price","Discount","Description","CategoryId","ImageUrl")]AddProductRequest request)
        {
            if (ModelState.IsValid)
            {
                int addedProductId = await productService.AddProduct(request);
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        // TODO 1: Update ve Delete işlemleri yazılacak.
        // TODO 2: Authentication ve Authorization ele alınacak!
        // TODO 3: Sepet işlemleri üzerinden Session ele alınacak.

    }
}
