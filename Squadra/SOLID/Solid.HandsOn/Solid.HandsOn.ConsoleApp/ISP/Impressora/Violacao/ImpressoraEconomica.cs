using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Impressora.Violacao
{
    public class ImpressoraEconomica : IImpressora
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo...");
        }

        public void Digitalizar()
        {
            throw new NotImplementedException();
        }

        public void FazerCopia()
        {
            throw new NotImplementedException();
        }
    }
}