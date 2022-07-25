using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;

namespace Primeiro.LoaderController
{
    class ExemploDictionaryController : LoadController
    {
        public override void Rodar()
        {
            // Dictionary e SortedDictionary - a sua diferença é apenas que uma é ordenada e a outra não, entretanto observar a performance, o padrão ordenado é mais pesado para ser executado.
            Console.WriteLine("Exemplo da estrutura de dados Dictionary - SortedDictionary");

            Dictionary<string, string> cookies = new Dictionary<string, string>();
            // poderia-se incluir usando cookies.add mas da forma abaixo é uma forma resumida de se fazer uma inclusao na coleção.
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }
            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");
            //foreach (var item in cookies) // O foreach poderia ter sido declarado desta forma, porem foi deixado na forma verbosa apenas pra aprendizado.
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
