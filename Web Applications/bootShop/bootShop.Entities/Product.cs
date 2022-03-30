using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Entities
{
   public class Product : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adı boş olamaz")]
        public string Name { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string Descriptipn { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public string ImageUrl { get; set; }

        public Category Category { get; set; }
    }
}
