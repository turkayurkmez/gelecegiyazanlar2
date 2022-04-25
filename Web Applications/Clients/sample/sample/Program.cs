// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
var array = Convert.FromBase64String("YWRtaW46MTIz");
var result = Encoding.UTF8.GetString(array);
Console.WriteLine(result);