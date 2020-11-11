namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Regras
{
    public class RegraDeCalculoDezOuQuinzePorCento : IRegraDeCalculo
    {
        public bool CalculoSeAplicaAoCargo(Cargo cargo)
        {
            return cargo == Cargo.Desenvolvedor;
        }

        public double Calcular(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.85;
            }

            return funcionario.SalarioBase * 0.9;
        }
    }
}