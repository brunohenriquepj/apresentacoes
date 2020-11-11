using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions.Brazil;
using Microsoft.Extensions.DependencyInjection;
using Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao;
using Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Factories;
using Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Regras;
using Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao;

namespace Solid.HandsOn.ConsoleApp
{
    class Program
    {
        private static readonly Faker Faker = new Faker("pt_BR");

        static async Task Main(string[] args)
        {
            // await ExemploSRP_DIP();
            // ExemploOCP();
        }

        private static async Task ExemploSRP_DIP()
        {
            var smtpClient = new SmtpClient
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com"
            };

            var sqlConnection = new SqlConnection("Server=localhost;Database=myDataBase;User Id=myUsername;Password=myPassword;");

            var serviceProvider = new ServiceCollection()
                .AddTransient<IClienteService, ClienteService>()
                .AddTransient<IClienteValidator, ClienteValidator>()
                .AddTransient<IClienteRepository, ClienteRepository>()
                .AddTransient<IEmailService, EmailService>()
                .AddTransient(provider => smtpClient)
                .AddTransient(provider => sqlConnection)
                .AddTransient<IClienteAdapter, ClienteAdapter>()
                .BuildServiceProvider();

            var clienteService = serviceProvider.GetService<IClienteService>();

            var cliente = new Cliente(Faker.Person.FirstName, null, Faker.Person.Cpf(includeFormatSymbols: false));
            try
            {
                await clienteService.AdicionarCliente(cliente);
            }
            catch (SRP_DIP.CadastroDeCliente.Solucao.ValidationException exception)
            {
                Console.WriteLine($"Ocorreu um erro de validação: {exception.Message}");
                Console.WriteLine($"Erros: {string.Join(" ", exception.Errros)}");
            }
        }

        private static void ExemploOCP()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IRegraDeCalculo, RegraDeCalculoDezOuQuinzePorCento>()
                .AddTransient<IRegraDeCalculo, RegraDeCalculoVinteOuVinteECincoPorCento>()
                .AddTransient<IRegraDeCalculoFactory, RegraDeCalculoFactory>()
                .AddTransient<ICalculadoraSalario, CalculadoraSalario>()
                .BuildServiceProvider();

            var calculador = serviceProvider.GetService<ICalculadoraSalario>();

            var salarioCalculado = calculador.Calcular(new Funcionario(Cargo.Dba, 1000));
            Console.WriteLine($"Salário calculado: {salarioCalculado}");
        }
    }
}
