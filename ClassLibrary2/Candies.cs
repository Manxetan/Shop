namespace Magazin
{
    public class Candies : Product
    {
        public string Type { get; private set; }
        public int Quantity { get; private set; }
        public int Pr_1 { get; private set; }
        public Candies(string name, int price, string manufacture, string type, int quantity,int pr_1)
        {
            Name = name;
            Manufacture = manufacture;
            Price = price;
            Type = type;
            Quantity = quantity;
            Pr_1 = pr_1;
        }

        public override double GetDiscountPrice(Buyer buyer)
        {
            return Price *0.8;
        }
    }
}