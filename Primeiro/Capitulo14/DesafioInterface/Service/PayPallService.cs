using Primeiro.Capitulo14.DesafioInterface.Interface;

namespace Primeiro.Capitulo14.DesafioInterface.Service
{
    class PayPallService : IServicoPagamentoOnline
    {
        private const double TaxaDeServico = 0.02;
        private const double TaxaDeJuros = 0.01;

        public double Parcela(double valor, int meses)
        {
            return valor * TaxaDeJuros * meses;
        }

        public double TaxaDePagamento(double amount)
        {
            return amount * TaxaDeServico;
        }
    }
}
