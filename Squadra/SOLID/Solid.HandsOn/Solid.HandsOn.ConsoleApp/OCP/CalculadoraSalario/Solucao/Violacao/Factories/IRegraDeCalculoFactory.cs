using Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Regras;

namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Factories
{
    public interface IRegraDeCalculoFactory
    {
        IRegraDeCalculo ObterRegra(Cargo cargo);
    }
}