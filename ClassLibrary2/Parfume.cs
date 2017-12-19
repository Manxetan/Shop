namespace Magazin
{
    public class Parfume : Product
    {
        public string Smell { get; private set; }

        public Parfume(string name, int price, string manufacture, string smell)
        {
            Name = name;
            Manufacture = manufacture;
            Price = price;
            Smell = smell;
        }

        public override double GetDiscountPrice(Buyer buyer)
        {
            return Price / 3;
        }
    }
}