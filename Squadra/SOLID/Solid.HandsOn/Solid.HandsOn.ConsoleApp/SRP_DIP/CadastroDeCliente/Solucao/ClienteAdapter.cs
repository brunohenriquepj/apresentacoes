namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class ClienteAdapter : IClienteAdapter
    {
        public EnviarEmailDto ConverteParaEnviarEmailDto(Cliente cliente)
        {
            return new EnviarEmailDto
            {
                Destinatario = cliente.Email,
                Assunto = "Bem Vindo.",
                Conteudo = "Parabéns! Você está cadastrado."
            };
        }
    }
}