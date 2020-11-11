using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Impressora.Solucao
{
    public class ImpressoraEconomica : IImpressora
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo...");
        }
    }
}