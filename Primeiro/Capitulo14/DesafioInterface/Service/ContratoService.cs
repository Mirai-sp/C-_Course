using System;
using Primeiro.Capitulo14.DesafioInterface.Entities;
using Primeiro.Capitulo14.DesafioInterface.Interface;

namespace Primeiro.Capitulo14.DesafioInterface.Service
{
    class ContratoService
    {
        private IServicoPagamentoOnline _servicoPagamento;
        
        public ContratoService(IServicoPagamentoOnline servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }
        public void ProcessarContrato(Contrato contrato, int mes)
        {
            double aliquotaBasica = contrato.ValorTotal / mes;
            for (int i = 1; i <= mes; i++)
            {
                DateTime date = contrato.Data.AddMonths(i);
                double aliquotaAtualizada = aliquotaBasica + _servicoPagamento.Parcela(aliquotaBasica, i);
                double fullQuota = aliquotaAtualizada + _servicoPagamento.TaxaDePagamento(aliquotaAtualizada);
                contrato.AdicionarParcela(new Parcela(date, fullQuota));
            }
        }
    }
}
