using System;

namespace Solid.HandsOn.ConsoleApp.LSP.Conta.Violacao
{
    public class ContaComum
    {
        public double Saldo { get; private set; }

        public ContaComum()
        {
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            const int valorMinimoDeSaque = 0;
            if (valor <= valorMinimoDeSaque)
                throw new ArgumentException("Valor de depósito deve maior que zero.");

            Saldo += valor;
        }

        public virtual void Render()
        {
            Saldo *= 1.01;
        }
    }
}