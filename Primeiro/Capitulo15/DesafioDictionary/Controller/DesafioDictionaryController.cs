using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Entities
{
    class DesafioDictionaryController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Desafio de Dictionary");
            String[] persons = new String[]
            {
                "Alex Blue,15", 
                "Maria Green,22",
                "Bob Brown,21",
                "Alex Blue,30",
                "Bob Brown,15",
                "Maria Green,27",
                "Maria Green,22",
                "Bob Brown,25",
                "Alex Blue,31"
            };

            Dictionary <string, int> votes = new Dictionary<string, int>();
            foreach (string person in persons)
            {
                string[] vet = person.Split(',');
                if (votes.ContainsKey(vet[0]))
                    votes[vet[0]] += int.Parse(vet[1]);
                else
                    votes[vet[0]] = int.Parse(vet[1]);
            }

            foreach (var item in votes)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
