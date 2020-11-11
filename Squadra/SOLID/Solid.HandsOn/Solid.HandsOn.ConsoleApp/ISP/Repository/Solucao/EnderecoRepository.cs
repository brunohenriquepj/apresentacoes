using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Repository.Solucao
{
    class EnderecoRepository : IReadOnlyRepository
    {
        public void ObterTodos()
        {
            Console.WriteLine("Obtém endereços...");
        }
    }
}