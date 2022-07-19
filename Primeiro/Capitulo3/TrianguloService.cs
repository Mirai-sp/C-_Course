using System;
using System.Globalization;

namespace Primeiro.Capitulo3
{
    class TrianguloService
    {
        public static void Rodar()
        {
            Triangulo trianguloA = new Triangulo();
            trianguloA.A = 3;
            trianguloA.B = 4;
            trianguloA.C = 5;

            Triangulo trianguloB = new Triangulo();
            trianguloB.A = 7.50;
            trianguloB.B = 4.50;
            trianguloB.C = 4.02;

            /* é possível instanciar uma classe e já iniciar seus valores sem usar o construtor para isso usa-se { } mas as variaveis devem ser publicas pelos testes
            Triangulo TranguloC = new Triangulo
            {
                A = 7.50,
                B = 4.50,
                C = 4.02
            };
            */

            Console.WriteLine("As areas dos triangulos são: {0} e {1}", trianguloA.CalcularArea().ToString("F4", CultureInfo.InvariantCulture), trianguloB.CalcularArea().ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Triangulo A: " + trianguloA.ToString());
            Console.WriteLine("Triangulo B: " + trianguloB.ToString());
            Console.WriteLine("Lendo ReadOnlyAutoProperty: " + trianguloA.ExemploReadOnlyAutoProperty);
            trianguloA.ExemploAutoProperty = "Mudei a property";
            Console.WriteLine("Lendo AutoProperty: " + trianguloA.ExemploAutoProperty);
        }
    }
}
