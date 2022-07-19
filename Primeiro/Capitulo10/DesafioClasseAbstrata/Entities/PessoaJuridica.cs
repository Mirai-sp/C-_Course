using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Capitulo10.DesafioClasseAbstrata.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumeroFuncionarios { get; set; }
        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        public override double TotalImposto()
        {
            double tax = (NumeroFuncionarios > 10 ? 14.0 : 16.0) / 100.0;
            return RendaAnual * tax;
        }
    }
}
