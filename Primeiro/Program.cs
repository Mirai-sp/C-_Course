using System;
using System.Globalization;
using Primeiro.Capitulo2;


namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int runOpt = -1;
            int maxOpt = 2;
            Console.WriteLine("O que deseja rodar:");
            while (runOpt == -1)
            {
                Console.WriteLine("1. Exemplo Capitulo 1");
                Console.WriteLine("2. Exemplo Capitulo 1");
                Console.Write("Digite a opção desejada: ");
                
                try
                {
                    runOpt = int.Parse(Console.ReadLine());
                    if (!(runOpt >= 1 && runOpt <= maxOpt))
                        throw new Exception("Escolha um numero válido");

                    switch (runOpt)
                    {
                        case 1:
                            RodarExemplo1();
                            break;
                        case 2:
                            RodarExemplo2();
                            break;
                    }
                } catch (Exception e)
                {
                    runOpt = -1;                    
                    Console.WriteLine("Digite uma opção válida, escolha entre 1 e {0}", maxOpt);
                }                
            }
        }

        public static void RodarExemplo1()
        {
            Exemplo exemplo = new Exemplo();
            exemplo.Rodar();
        }

        public static void RodarExemplo2()
        {
            Triangulo trianguloA = new Triangulo();
            trianguloA.SetA(3);
            trianguloA.SetB(4);
            trianguloA.SetC(5);

            Triangulo trianguloB = new Triangulo();
            trianguloB.SetA(7.50);
            trianguloB.SetB(4.50);
            trianguloB.SetC(4.02);

            Console.WriteLine("As areas dos triangulos são: {0} e {1}", trianguloA.CalcularArea().ToString("F4", CultureInfo.InvariantCulture), trianguloB.CalcularArea().ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Triangulo A: " + trianguloA.ToString());
            Console.WriteLine("Triangulo B: " + trianguloB.ToString());


        }
    }
}
