using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Capitulo15.ExemploHashSetSortedSet.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Product other = obj as Product;
            if (!(obj is Product))
                return false;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}


