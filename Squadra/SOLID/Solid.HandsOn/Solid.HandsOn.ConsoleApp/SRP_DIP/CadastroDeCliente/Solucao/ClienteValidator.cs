using System.Collections.Generic;
using System.Linq;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class ClienteValidator : IClienteValidator
    {
        public void Validar(Cliente cliente)
        {
            var errors = new List<string>();
            const string validationExceptionMessage = "Cliente inválido.";

            if (cliente == null)
            {
                throw new ValidationException(validationExceptionMessage,
                    new[] {"Cliente obrigatório."});
            }

            if (cliente.Email == null)
            {
                errors.Add("Email obrigatório.");
            }
            else if (!cliente.Email.Contains("@"))
            {
                errors.Add("Email inválido.");
            }

            const int tamanhoCpf = 11;
            if (string.IsNullOrWhiteSpace(cliente.Cpf))
            {
                errors.Add("Cpf obrigatório.");
            }
            else if (cliente.Cpf?.Length != tamanhoCpf)
            {
                errors.Add("Cpf inválido.");
            }

            if (errors.Any()) throw new ValidationException(validationExceptionMessage, errors);
        }
    }
}