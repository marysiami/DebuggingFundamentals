using System;

namespace Task1
{
    public class Product
    {
        public string Name { get; }

        public double Price { get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product other))
                return false;

            if (Name == other.Name && Math.Abs(Price - other.Price) < 0.0000001)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
 