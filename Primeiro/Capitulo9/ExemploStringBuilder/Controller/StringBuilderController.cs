using System;
using Primeiro.Capitulo9.ExemploStringBuilder.Entities;
using Primeiro.Entities;

namespace Primeiro.LoaderController
{
    class StringBuilderController : LoadController
    {
        public override void Rodar()
        {
            Post post = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Viajando para a Nova Zelandia", "Eu estou indo visitar este incrível país.", 3);
            post.AddComment(new Comment("Tenha uma boa viagem"));
            post.AddComment(new Comment("Wow isto é incrível"));

            Post post2 = new Post(DateTime.Now, "Boa noite pessoal", "Vejo vocês amanhã", 4);
            post2.AddComment(new Comment("Boa noite."));
            post2.AddComment(new Comment("Que a força esteja com você"));

            Post post3 = new Post(DateTime.Now, "Boa dia pessoal", "Vejo vocês mais tarde", 4);

            Console.WriteLine(post);
            Console.WriteLine(post2);
            Console.WriteLine(post3);
        }
    }
}
