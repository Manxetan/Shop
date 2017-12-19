namespace Magazin
{
    public class Socks : Product
    {
        public string Color { get; private set; }
        public int Size { get; private set; }

        public Socks(string name, int price, string manufacture, string color, int size)
        {
            Name = name;
            Manufacture = manufacture;
            Price = price;
            Color = color;
            Size = size;
        }

        public override double GetDiscountPrice(Buyer buyer)
        {
            return Price / 2;
        }
    }
}