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

        public bool Equals(Product other) => other != null && 
            this.Name == other.Name && 
            this.Price == other.Price;

        ///<inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Product);

        ///<inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(this.Name, this.Price);
    }
}
