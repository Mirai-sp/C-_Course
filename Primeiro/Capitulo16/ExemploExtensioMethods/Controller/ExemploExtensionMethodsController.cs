using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;

namespace Primeiro.LoaderController
{
    class ExemploExtensionMethodsController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo de Extension Methods");
            DateTime now = DateTime.Now;            
            DateTime dt = new DateTime(now.Ticks).AddHours(-12.5);
            DateTime dt2 = new DateTime(now.Ticks).AddHours(-26.5);

            Console.WriteLine("Now:" + now.ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Compare:" + dt.ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture));
            Console.WriteLine("Elapsed time: " + dt.ElapsedTime());
            Console.WriteLine();
            Console.WriteLine("Compare:" + dt2.ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture));
            Console.WriteLine("Elapsed time: " + dt2.ElapsedTime());

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
