namespace apiWithdotNetSix.Controllers
{
    internal class Product
    {
        public int Id { get; internal set; }
        public string? Name { get; internal set; }
        public string Category { get; internal set; }
        public decimal Price { get; internal set; }
    }
}