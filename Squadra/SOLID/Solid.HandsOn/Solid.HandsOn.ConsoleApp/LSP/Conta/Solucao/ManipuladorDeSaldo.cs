using System;

namespace Solid.HandsOn.ConsoleApp.LSP.Conta.Solucao
{
    public class ManipuladorDeSaldo
    {
        public ManipuladorDeSaldo(double saldo)
        {
            Saldo = saldo;
        }

        public double Saldo { get; private set; }
        
        public void Depositar(double valor, double valorMinimoDeSaque)
        {
            if (valor <= valorMinimoDeSaque)
                throw new ArgumentException("Valor de depósito deve maior que zero.");

            Saldo += valor;
        }
        
        public virtual void Render(double juros)
        {
            Saldo *= juros;
        }
    }
}