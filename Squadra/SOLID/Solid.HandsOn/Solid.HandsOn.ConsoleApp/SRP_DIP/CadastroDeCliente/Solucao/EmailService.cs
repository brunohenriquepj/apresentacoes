using System.Net.Mail;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient _emailClient;

        public EmailService(SmtpClient emailClient)
        {
            _emailClient = emailClient;
        }

        public void Enviar(EnviarEmailDto enviarEmailDto)
        {
            using var mailMessage = new MailMessage(EmailConstantes.Remetente,
                enviarEmailDto.Destinatario,
                enviarEmailDto.Assunto,
                enviarEmailDto.Conteudo);

            _emailClient.Send(mailMessage);
        }
    }
}