using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddDistributedSqlServerCache(options => {
    options.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DistributedCacheDb;Integrated Security=True;";
    options.SchemaName = "dbo";
    options.TableName = "TestCache";

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Lifetime.ApplicationStarted.Register(() =>
{
    var products = new[] { "IPhone", "Samsung", "Xiaomi" };
    var json = JsonConvert.SerializeObject(products);
    //var encoded = Encoding.UTF8.GetBytes(json);

    var option = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(5));

    app.Services.GetService<IDistributedCache>().SetString("products", json, option);


});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
