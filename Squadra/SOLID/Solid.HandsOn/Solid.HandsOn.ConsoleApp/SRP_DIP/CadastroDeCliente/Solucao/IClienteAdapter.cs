namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public interface IClienteAdapter
    {
        EnviarEmailDto ConverteParaEnviarEmailDto(Cliente cliente);
    }
}