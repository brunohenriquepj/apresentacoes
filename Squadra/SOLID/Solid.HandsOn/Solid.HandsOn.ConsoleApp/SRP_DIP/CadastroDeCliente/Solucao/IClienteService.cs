using System.Threading.Tasks;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public interface IClienteService
    {
        Task AdicionarCliente(Cliente cliente);
    }
}