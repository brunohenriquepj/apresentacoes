namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class EnviarEmailDto
    {
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
    }
}