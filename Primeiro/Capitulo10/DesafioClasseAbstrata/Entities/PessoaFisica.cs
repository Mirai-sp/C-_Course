using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Capitulo10.DesafioClasseAbstrata.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }
        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
        public override double TotalImposto()
        {
            double tax = (RendaAnual < 20000.0 ? 15.0 : 25.0) / 100.0;
            double totalTax = RendaAnual * tax;
            if (GastosSaude > 0)
                totalTax -= (GastosSaude * (50.0 / 100.0));

            return totalTax;
        }
    }
}
