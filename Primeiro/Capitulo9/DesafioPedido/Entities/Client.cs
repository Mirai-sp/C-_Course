using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Capitulo9.DesafioPedido.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ").AppendLine(Name).
            Append("Birth Date: ").AppendLine(BirthDate.ToString("dd/MM/yyyy")).
            Append("Email: ").AppendLine(Email);

            return sb.ToString();
        }
    }
}
