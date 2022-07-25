using System;
using Primeiro.Entities;
using Primeiro.Capitulo15.ExemploEqualsEHashCode.Entities;

namespace Primeiro.LoaderController
{
    class ExemploEqualsEHashCodeController : LoadController
    {
    public override void Rodar()
    {
        Console.WriteLine("Exemplo de Equals e HashCode");
        Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
        Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
        Client c = new Client { Name = "Alex", Email = "maria@gmail.com" };
        Client d = new Client { Name = "Alex", Email = "alex@gmail.com" };

        Console.WriteLine("a equals b: " + a.Equals(b)); // false        
        Console.WriteLine("a equals c: " + a.Equals(c)); // true pois no criteiro equals da classe cliente foi o email
        Console.WriteLine("a == d: " + (a == d)); // cuidado

        Console.WriteLine();
        Console.WriteLine("a hashcode: " + a.GetHashCode());
        Console.WriteLine("b hashcode: " + b.GetHashCode());
        Console.WriteLine("c hashcode: " + c.GetHashCode());
        Console.WriteLine("d hashcode: " + d.GetHashCode());
    }
}
}
