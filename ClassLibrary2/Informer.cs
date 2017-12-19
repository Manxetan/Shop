using System;

namespace Magazin
{
    public class Informer
    {
        public void Buy(Buyer buyer, Product product)
        {
            double price = product.GetDiscountPrice(buyer);
            buyer.ReduceBalance(price);
            Console.WriteLine($"{buyer.Name} купил {product.Name} за {price}. Заказ отправлен на склад");
        }
    }
}