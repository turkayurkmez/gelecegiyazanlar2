using bootShop.Business;
using bootShop.Business.MapperProfile;
using bootShop.DataAccess.Data;
using bootShop.DataAccess.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "bootShop.API", Version = "v1" });
            });
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<IUserService, FakeUserService>();



            var connectionString = Configuration.GetConnectionString("db");

            services.AddDbContext<bootShopDbContext>(opt => opt.UseSqlServer(connectionString));
            services.AddAutoMapper(typeof(MapProfile));

            services.AddCors(opt => opt.AddPolicy("Allow", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));

            //1. Üret
            //2. Denetle ve onayla
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Burası çok ama çok gizli bir ifade"));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(opt =>
                    {
                        opt.SaveToken = true;
                        opt.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateActor = true,
                            ValidateIssuer = true,
                            ValidateAudience = true,

                            ValidIssuer = "turkcell.com.tr",
                            ValidAudience = "turkcell.com.tr",
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = key
                        };
                    });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Run(async x =>
            //await x.Response.WriteAsync("This is a terminal middleware")
            //);



            app.Map("/test", xapp => xapp.Run(async x =>
            {
                var queryExists = x.Request.Query.ContainsKey("id");
                if (queryExists)
                {
                    var id = int.Parse(x.Request.Query["id"]);
                    var scope = app.ApplicationServices.CreateScope();
                    var productService = scope.ServiceProvider.GetRequiredService<IProductService>();
                    if (await productService.IsExist(id))
                    {
                        await x.Response.WriteAsync($"{id} id'li urun mevcut");
                    }
                    else
                    {
                        await x.Response.WriteAsync($"{id} id'li urun mevcut deil");

                    }

                }
                else
                {
                    await x.Response.WriteAsync($"id degeri yok :( ");
                }

            }));

            app.Use(async (context, next) =>
            {
                Console.WriteLine(context.Request.Method);
                var isJsonContent = context.Request.HasJsonContentType();
                Console.WriteLine(isJsonContent);
                if (isJsonContent)
                {
                    object body = await context.Request.ReadFromJsonAsync<object>();
                    dynamic type = JsonConvert.DeserializeObject<dynamic>(body.ToString());
                    //Console.WriteLine(type.name);
                }

                await next.Invoke();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "bootShop.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Allow");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
