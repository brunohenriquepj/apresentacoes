using System;
using Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Factories;

namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao
{
    public class CalculadoraSalario : ICalculadoraSalario
    {
        private readonly IRegraDeCalculoFactory _regraDeCalculoFactory;

        public CalculadoraSalario(IRegraDeCalculoFactory regraDeCalculoFactory)
        {
            _regraDeCalculoFactory = regraDeCalculoFactory;
        }

        public double Calcular(Funcionario funcionario)
        {
            var regra = _regraDeCalculoFactory.ObterRegra(funcionario.Cargo);

            if (regra == null)
                throw new InvalidOperationException("Funcionário inválido.");

            return regra.Calcular(funcionario);
        }
    }
}