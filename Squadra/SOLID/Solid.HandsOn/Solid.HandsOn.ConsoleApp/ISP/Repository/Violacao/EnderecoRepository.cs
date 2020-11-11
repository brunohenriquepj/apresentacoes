using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Repository.Violacao
{
    class EnderecoRepository : IRepository
    {
        public void ObterTodos()
        {
            Console.WriteLine("Obtém endereços...");
        }

        public void Inserir()
        {
            throw new NotImplementedException();
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }
    }
}