using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Repository.Solucao
{
    class UsuarioRepository : IReadOnlyRepository, IWriteOnlyRepository
    {
        public void ObterTodos()
        {
            Console.WriteLine("Obtém usuários...");
        }

        public void Inserir()
        {
            Console.WriteLine("Insere usuário...");
        }

        public void Atualizar()
        {
            Console.WriteLine("Atualiza usuário...");
        }
    }
}