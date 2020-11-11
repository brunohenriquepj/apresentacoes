using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Violacao
{
    public class ClienteService
    {
        public async Task AdicionarCliente(Cliente cliente)
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

            var connection = new SqlConnection("Server=localhost;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            var command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "insert into cliente (id, nome, email, cpf) value (@id, @nome, @email, @cpf))"
            };

            command.Parameters.AddWithValue("id", cliente.Id.ToString());
            command.Parameters.AddWithValue("nome", cliente.Nome);
            command.Parameters.AddWithValue("email", cliente.Email);
            command.Parameters.AddWithValue("cpf", cliente.Cpf);

            connection.Open();
            await command.ExecuteNonQueryAsync();
            connection.Close();
            
            using var smtpClient = new SmtpClient
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com"
            };

            using var mailMessage = new MailMessage(EmailConstantes.Remetente,
                cliente.Email,
                "Bem Vindo.", "Parabéns! Você está cadastrado.");
            smtpClient.Send(mailMessage);
        }
    }
}