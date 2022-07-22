using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Capitulo14.DesafioInterface.Entities;

namespace Primeiro.Capitulo14.DesafioInterface.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> Parcelas { get; private set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcela>();
        }

        public void AdicionarParcela(Parcela parc)
        {
            Parcelas.Add(parc);
        }

        public void RemoverParcela(Parcela parc)
        {
            Parcelas.Remove(parc);
        } 
    }
}
