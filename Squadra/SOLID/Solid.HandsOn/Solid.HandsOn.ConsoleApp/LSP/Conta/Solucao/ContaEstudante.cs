namespace Solid.HandsOn.ConsoleApp.LSP.Conta.Solucao
{
    public class ContaEstudante : IContaDepositavel
    {
        private readonly ManipuladorDeSaldo _manipuladorDeSaldo;

        public ContaEstudante()
        {
            _manipuladorDeSaldo = new ManipuladorDeSaldo(0);
        }
        
        public void Depositar(double valor)
        {
            _manipuladorDeSaldo.Depositar(valor, 10);
        }
    }
}