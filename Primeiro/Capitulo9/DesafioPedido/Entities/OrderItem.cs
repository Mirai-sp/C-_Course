using System;
using System.Globalization;
using System.Text;

namespace Primeiro.Capitulo9.DesafioPedido.Entities
{
    class OrderItem
    {
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Product: ").AppendLine(Product.Name).
            Append("Quantity: ").AppendLine(Quantity.ToString()).
            Append("Price: ").AppendLine(Price.ToString("F2", CultureInfo.InvariantCulture)).
            Append("Sub Total:").AppendLine(SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
