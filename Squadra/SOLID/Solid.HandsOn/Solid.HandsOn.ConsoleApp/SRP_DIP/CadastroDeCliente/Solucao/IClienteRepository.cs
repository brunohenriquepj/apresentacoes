using System.Threading.Tasks;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public interface IClienteRepository
    {
        Task Inserir(Cliente cliente);
    }
}