public class ProductListResponse
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string Descriptipn { get; set; }
        public int? CategoryId { get; set; }
        public string ImageUrl { get; set; }
    }