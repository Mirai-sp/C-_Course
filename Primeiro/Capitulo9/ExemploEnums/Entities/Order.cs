using System;
using Primeiro.Capitulo9.ExemploEnums.Enums;

namespace Primeiro.Capitulo9.ExemploEnums.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Moment
                   + ", "
                   + Status;
        }
    }
}
