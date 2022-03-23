using bootShop.Business;
using bootShop.Entities;
using bootShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bootShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }



        public IActionResult Index(int page=1)
        {
            var products = productService.GetProducts();
            var productsPerPage = 3;

            var paginatedPrdoucts = products.OrderBy(x => x.Id)
                                            .Skip((page - 1) * productsPerPage)
                                            .Take(productsPerPage);

            ViewBag.TotalPages = Math.Ceiling((decimal)products.Count / productsPerPage);
            return View(paginatedPrdoucts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
