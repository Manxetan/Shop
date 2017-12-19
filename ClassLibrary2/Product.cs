namespace Magazin
{
    public class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }

        public virtual double GetDiscountPrice(Buyer buyer)
        {
            if (buyer.Spent < 300)
            {
                return Price;
            }

            if (buyer.Spent < 1000)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }
    }
}