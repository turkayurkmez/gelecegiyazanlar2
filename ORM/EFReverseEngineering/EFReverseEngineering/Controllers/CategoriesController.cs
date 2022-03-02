using EFReverseEngineering.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFReverseEngineering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ArchEADbContext archEADbContext;

        public CategoriesController(ArchEADbContext archEADbContext)
        {
            this.archEADbContext = archEADbContext; 
        }
        [HttpGet()]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await archEADbContext.Categories.ToListAsync();
            return Ok(categories);
        }
    }
}
