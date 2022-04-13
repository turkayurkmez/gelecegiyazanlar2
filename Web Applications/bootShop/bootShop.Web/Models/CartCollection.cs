using bootShop.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootShop.Web.Models
{

    public class CartItem
    {
        public ProductListResponse Product { get; set; }
        public int Quantity { get; set; }
    }
    public class CartCollection
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public void Add(CartItem item)
        {
            var finding = CartItems.Find(c => c.Product.Id == item.Product.Id);
            if (finding == null)
            {
                CartItems.Add(item);
            }
            else
            {
                finding.Quantity += item.Quantity;
            }
        }
        public void ClearAll() => CartItems.Clear();

        public double GetTotalPrice() => CartItems.Sum(c => c.Product.Price.Value * (1-c.Product.Discount.Value) * c.Quantity);
        public void Delete(int id) => CartItems.RemoveAll(c => c.Product.Id==id);

    }

}
