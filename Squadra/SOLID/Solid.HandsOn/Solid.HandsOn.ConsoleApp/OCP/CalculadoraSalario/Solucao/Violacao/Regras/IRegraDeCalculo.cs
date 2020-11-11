namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Regras
{
    public interface IRegraDeCalculo
    {
        bool CalculoSeAplicaAoCargo(Cargo cargo);
        double Calcular(Funcionario funcionario);
    }
}