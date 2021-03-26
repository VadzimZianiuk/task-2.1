using System;

namespace Task1
{
    public class Product : IEquatable<Product>
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; }

        public double Price { get; }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return this.Equals(product);
            }

            return false;
        }

        public bool Equals(Product other)
        {
            if (other is null)
            {
                return false;
            }

            return string.CompareOrdinal(this.Name, other.Name) == 0 && this.Price == other.Price;
        }

        public override int GetHashCode() => HashCode.Combine(this.Name, this.Price);
    }
}
