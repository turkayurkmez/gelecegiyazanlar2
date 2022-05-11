using bootShop.API.Models;
using bootShop.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IProductService productService;
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public async Task< ActionResult> Login([FromBody] UserLoginModel model)
        {
            var user = userService.ValidateUser(model.userName, model.password);
            if (user != null)
            {
                //1. claim bilgileri:
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName,user.UserName),
                    new Claim(ClaimTypes.Role, user.Role),

                };

                //2. gizli cümlenin üretilmesi
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Burası çok ama çok gizli bir ifade"));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //3. token'ın özelliklerini tanımla:
                var token = new JwtSecurityToken(
                     issuer: "turkcell.com.tr",
                     audience: "turkcell.com.tr",
                     claims: claims,
                     notBefore: DateTime.Now,
                     expires: DateTime.Now.AddMinutes(20),
                     signingCredentials: credential
                    );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });




            }
            return BadRequest(new { message = "Hatalı kullanıcı adı ya da şifre" });
          
        }
    }
}
