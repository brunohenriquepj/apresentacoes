using System;

namespace Solid.HandsOn.ConsoleApp.ISP.Impressora.Solucao
{
    public class ImpressoraMultiFuncional : IImpressora, IDigitalizadora, ICopiadora
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo...");
        }

        public void Digitalizar()
        {
            Console.WriteLine("Digitalizando...");
        }

        public void FazerCopia()
        {
            Console.WriteLine("Fazendo copia...");
        }
    }
}