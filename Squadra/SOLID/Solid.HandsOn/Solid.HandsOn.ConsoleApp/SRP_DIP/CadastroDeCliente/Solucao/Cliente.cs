using System;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class Cliente
    {
        public Cliente(string nome, string email, string cpf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public Guid Id { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Cpf { get; }
    }
}