using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Primeiro.Entities;
using Primeiro.Helpers;
using Primeiro.Capitulo14.DesafioInterface.Entities;
using Primeiro.Capitulo14.DesafioInterface.Service;

namespace Primeiro.LoaderController
{
    class DesafioInterfaceController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Informe os dados do contrato");
            int numeroContrato = int.Parse(FunctionsHelper.getFromConsole("Número: "));
            DateTime dataContrato = DateTime.ParseExact(FunctionsHelper.getFromConsole("Data do Contrato (dd/MM/yyyy): "), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            double valorContrato = double.Parse(FunctionsHelper.getFromConsole("Valor: "), CultureInfo.InvariantCulture);
            int parcelasContrato = int.Parse(FunctionsHelper.getFromConsole("Parcelas: "));

            Contrato cont = new Contrato(numeroContrato, dataContrato, valorContrato);
            ContratoService contService = new ContratoService(new PayPallService());

            contService.ProcessarContrato(cont, parcelasContrato);
            Console.WriteLine("Parcelas");
            foreach (Parcela parc in cont.Parcelas)
                Console.WriteLine(parc);
        }
    }
}
