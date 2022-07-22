namespace Primeiro.Capitulo14.DesafioInterface.Interface
{
    interface IServicoPagamentoOnline
    {
        double Parcela(double valor, int meses);
        double TaxaDePagamento(double valor);        
    }
}
