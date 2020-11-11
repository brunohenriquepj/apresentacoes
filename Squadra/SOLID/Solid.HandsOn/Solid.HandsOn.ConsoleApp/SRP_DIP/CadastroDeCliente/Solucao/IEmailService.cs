namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public interface IEmailService
    {
        void Enviar(EnviarEmailDto enviarEmailDto);
    }
}