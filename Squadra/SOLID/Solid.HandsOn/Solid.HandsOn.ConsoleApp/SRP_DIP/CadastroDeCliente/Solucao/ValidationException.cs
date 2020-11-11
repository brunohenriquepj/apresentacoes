using System;
using System.Collections.Generic;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class ValidationException : Exception
    {
        public IEnumerable<string> Errros { get; }

        public ValidationException(string message, IEnumerable<string> errros) : base(message)
        {
            Errros = errros;
        }
    }
}