namespace Magazin
{
    public class Flower : Product
    {
        public string Type { get; private set; }
        public string Color { get; private set; }

        public Flower(string name, int price, string manufacture, string type, string color)
        {
            Name = name;
            Manufacture = manufacture;
            Price = price;
            Type = type;
            Color = color;
        }

        public override double GetDiscountPrice(Buyer buyer)
        {
            return Price / 2;
        }
    }
}