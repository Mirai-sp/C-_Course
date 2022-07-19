using System;
using System.Text;
using System.Globalization;

namespace Primeiro.Capitulo9.DesafioPedido.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string name)
        {
            Name = name;
        }

        public Product(string name, double price) : this(name)
        {
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ").AppendLine(Name).
            Append("Price: ").AppendLine(Price.ToString("F2", CultureInfo.InvariantCulture);

            return sb.ToString();
        }
    }
}
