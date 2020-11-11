using System.Collections.Generic;
using System.Linq;
using Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Regras;

namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Solucao.Violacao.Factories
{
    public class RegraDeCalculoFactory : IRegraDeCalculoFactory
    {
        private readonly IEnumerable<IRegraDeCalculo> _regrasDeCalculo;

        public RegraDeCalculoFactory(IEnumerable<IRegraDeCalculo> regrasDeCalculo)
        {
            _regrasDeCalculo = regrasDeCalculo;
        }

        private readonly IDictionary<Cargo, IRegraDeCalculo> _regraDeCalculos =
            new Dictionary<Cargo, IRegraDeCalculo>()
            {
                {Cargo.Desenvolvedor, new RegraDeCalculoDezOuQuinzePorCento()},
                {Cargo.Dba, new RegraDeCalculoVinteOuVinteECincoPorCento()},
                {Cargo.Tester, new RegraDeCalculoVinteOuVinteECincoPorCento()},
            };

        public IRegraDeCalculo ObterRegra(Cargo cargo)
        {
            return _regrasDeCalculo.FirstOrDefault(regra => regra.CalculoSeAplicaAoCargo(cargo));
            
            // Outra forma de implementação da factory com dictionary
            // return _regraDeCalculos.ContainsKey(cargo) ? _regraDeCalculos[cargo] : null;
        }
    }
}