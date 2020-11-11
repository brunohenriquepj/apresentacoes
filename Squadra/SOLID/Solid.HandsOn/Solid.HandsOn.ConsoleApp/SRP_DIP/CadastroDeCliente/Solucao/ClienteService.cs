using System.Threading.Tasks;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteValidator _validator;
        private readonly IEmailService _emailService;
        private readonly IClienteAdapter _adapter;

        public ClienteService(IClienteRepository clienteRepository, IClienteValidator validator,
            IEmailService emailService, IClienteAdapter adapter)
        {
            _clienteRepository = clienteRepository;
            _validator = validator;
            _emailService = emailService;
            _adapter = adapter;
        }

        public async Task AdicionarCliente(Cliente cliente)
        {
            _validator.Validar(cliente);

            await _clienteRepository.Inserir(cliente);

            _emailService.Enviar(_adapter.ConverteParaEnviarEmailDto(cliente));
        }
    }
}