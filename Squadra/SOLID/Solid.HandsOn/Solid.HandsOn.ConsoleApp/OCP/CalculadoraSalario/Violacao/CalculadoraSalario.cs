using System;

namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Violacao
{
    public class CalculadoraSalario
    {
        public double Calcular(Funcionario funcionario)
        {
            if (funcionario.Cargo == Cargo.Desenvolvedor)
            {
                return CalcularDezOuQuinzePorCento(funcionario);
            }

            if (funcionario.Cargo == Cargo.Dba || funcionario.Cargo == Cargo.Tester)
            {
                return CalcularVinteOuVinteECincoPorCento(funcionario);
            }

            throw new InvalidOperationException("Funcionário inválido.");
        }

        private static double CalcularVinteOuVinteECincoPorCento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }

            return funcionario.SalarioBase * 0.80;
        }

        private static double CalcularDezOuQuinzePorCento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.85;
            }

            return funcionario.SalarioBase * 0.9;
        }
    }
}