using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir nesne DEĞİŞİME KAPALI, GELİŞİME AÇIK olmalıdır.
             * 
             */

            Customer customer = new Customer { Name = "Türkay", Cart = new SilverCart() };
            OrderManager orderManager = new OrderManager { Customer = customer };
            Console.WriteLine(orderManager.GetDiscountedPrice(1000));
            
        }
    }

    public abstract class Cart
    {
        public abstract decimal GetDiscountedPrice(decimal price);
    }

    public class StandardCart : Cart
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .95M;

        }
    }

    public class SilverCart : Cart
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .90M;

        }
    }

    public class GoldCart : Cart
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85M;

        }
    }

    public class PremiumCart : Cart
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .80M;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Cart Cart { get; set; }
    }

    public class OrderManager
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal price)
        {
            //switch (Customer.Cart)
            //{
            //    case Cards.Standard:
            //        return price * .95M;

            //    case Cards.Silver:
            //        return price * .90M;
            //    case Cards.Gold:
            //        return price * .85M;
            //    default:
            //        return price;
            //}

            return Customer.Cart.GetDiscountedPrice(price);

        } 
    }

}
