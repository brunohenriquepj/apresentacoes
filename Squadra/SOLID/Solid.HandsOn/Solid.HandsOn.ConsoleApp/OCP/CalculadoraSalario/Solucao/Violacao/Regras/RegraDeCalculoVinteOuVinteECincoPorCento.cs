using System.Linq;

namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Regras
{
    public class RegraDeCalculoVinteOuVinteECincoPorCento : IRegraDeCalculo
    {
        private static readonly Cargo[] Cargos = {Cargo.Dba, Cargo.Tester};
        
        public bool CalculoSeAplicaAoCargo(Cargo cargo)
        {
            return Cargos.Contains(cargo);
        }

        public double Calcular(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }

            return funcionario.SalarioBase * 0.80;
        }
    }
}