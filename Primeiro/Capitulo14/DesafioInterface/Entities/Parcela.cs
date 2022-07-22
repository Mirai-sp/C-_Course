using System;
using System.Globalization;

namespace Primeiro.Capitulo14.DesafioInterface.Entities
{
    class Parcela
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Parcela(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }
        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
