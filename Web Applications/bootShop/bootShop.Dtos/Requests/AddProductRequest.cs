using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Dtos.Requests
{
    public class AddProductRequest
    {
        [Required(ErrorMessage = "Ürün adını boş bırakmayınız")]
        [MinLength(3, ErrorMessage ="Ürün adı en az üç karakter olmalıdır")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string Descriptipn { get; set; }
        public int? CategoryId { get; set; }
        public string ImageUrl { get; set; }

    }
}
