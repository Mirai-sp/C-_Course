using System;

namespace Primeiro.Capitulo11.ExemploCustomExceptions.Exceptions
{
    class DomainException : ApplicationException // classe base para exceções customizadas personalizadas
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}