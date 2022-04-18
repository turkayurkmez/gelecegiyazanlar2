// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");
getDataFromWebApi();

static void getDataFromWebApi()
{
    System.Console.WriteLine("deneme");
    var client = new HttpClient();
    var response = client.GetAsync("https://localhost:44333/api/Products").Result;
    if (response.IsSuccessStatusCode)
    {
        var content = response.Content.ReadFromJsonAsync<List<ProductListResponse>>().Result;
        content?.ForEach(x =>
        {
            System.Console.WriteLine($"{x.Id} {x.Name} {x.Price} {x.Discount} {x.Descriptipn} ");
        });

    }
}