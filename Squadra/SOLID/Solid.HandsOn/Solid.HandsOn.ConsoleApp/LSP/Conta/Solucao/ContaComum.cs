namespace Solid.HandsOn.ConsoleApp.LSP.Conta.Solucao
{
    public class ContaComum : IContaRentavel, IContaDepositavel
    {
        private readonly ManipuladorDeSaldo _manipuladorDeSaldo;
        public double Saldo => _manipuladorDeSaldo.Saldo;

        public ContaComum()
        {
            _manipuladorDeSaldo = new ManipuladorDeSaldo(0);
        }

        public void Depositar(double valor)
        {
            _manipuladorDeSaldo.Depositar(valor, 0);
        }

        public void Render()
        {
            _manipuladorDeSaldo.Render(1.01);
        }
    }
}