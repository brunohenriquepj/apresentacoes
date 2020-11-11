using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Solid.HandsOn.ConsoleApp.SRP_DIP.CadastroDeCliente.Solucao
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SqlConnection _connection;

        public ClienteRepository(SqlConnection connection)
        {
            _connection = connection;
        }
    
        public async Task Inserir(Cliente cliente)
        {
            var command = new SqlCommand
            {
                Connection = _connection,
                CommandType = CommandType.Text,
                CommandText =
                    "insert into cliente (id, nome, email, cpf) value (@id, @nome, @email, @cpf))"
            };

            command.Parameters.AddWithValue("id", cliente.Id.ToString());
            command.Parameters.AddWithValue("nome", cliente.Nome);
            command.Parameters.AddWithValue("email", cliente.Email);
            command.Parameters.AddWithValue("cpf", cliente.Cpf);

            _connection.Open();
            await command.ExecuteNonQueryAsync();
            _connection.Close();
        }
    }
}